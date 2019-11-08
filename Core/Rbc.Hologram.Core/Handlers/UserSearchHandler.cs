using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Exceptions;
using Rbc.Hologram.Contracts.Interfaces.Handlers;
using Rbc.Hologram.Core.Mappers;
using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rbc.Hologram.Core.Handlers
{
    public class UserSearchHandler : ICustomHandler<UserSearchRequest, List<UserDto>>
    {
        private IUserContext uContext;
        public UserSearchHandler(IUserContext uContext)
        {
            this.uContext = uContext;
        }

        public List<UserDto> Execute(UserSearchRequest request)
        {
            var users = new List<UserDto>();

            if (!string.IsNullOrEmpty(request.Password))
            {
                var user = uContext.Get(request.UserName, request.Password);

                if (user == null)
                    throw new NotFoundException("Not found", "No user exists for this cedential");

                users.Add(Mapper.Map(user));
            }
            else
            {
                users.AddRange(uContext.Get(request.UserName).Select(Mapper.Map));
            }
         
            return users;
        }
    }
}
