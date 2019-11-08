using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Interfaces.Contracts;
using Rbc.Hologram.Core.Handlers;
using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Contracts
{
    public class UserContract : IUserContract
    {
        private IUserContext uContext;
        public UserContract(IUserContext uContext)
        {
            this.uContext = uContext;
        }

        public UserAuthenticationResponse Authenticate(UserAuthenticationRequest request)
        {
            return new UserAuthenticateHandler(uContext).Execute(request);
        }

        public UserDto Get(int id)
        {
            return new UserHandler(uContext).Read(id);
        }

        public int Post(UserDto actionDto)
        {
            return new UserHandler(uContext).Create(actionDto);
        }

        public List<UserDto> Search(UserSearchRequest request)
        {
            return new UserSearchHandler(uContext).Execute(request);
        }
    }
}
