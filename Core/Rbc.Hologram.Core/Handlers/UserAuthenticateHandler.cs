using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Exceptions;
using Rbc.Hologram.Contracts.Interfaces.Handlers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Rbc.Hologram.Core.Handlers
{
    public class UserAuthenticateHandler : ICustomHandler<UserAuthenticationRequest, UserAuthenticationResponse>
    {
        private IUserContext uContext;
        public UserAuthenticateHandler(IUserContext uContext)
        {
            this.uContext = uContext;
        }
        public UserAuthenticationResponse Execute(UserAuthenticationRequest request)
        {
            var user = new UserSearchHandler(uContext).Execute(new UserSearchRequest
            {
                Password = request.Password,
                UserName = request.UserName
            });

            if (user == null || !user.Any())
                throw new AuthenticationFailedException("Authentication Failed", "User doesn't exists in system, Authentication failed");

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(ContractRegistration.JwtTokenKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.NameIdentifier,user.First().UserId.ToString()),
                    new Claim(ClaimTypes.Name, user.First().UserName)
                }),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return new UserAuthenticationResponse
            {
                UserName = user.First().UserName,
                Token = tokenString
            };
        }
    }
}
