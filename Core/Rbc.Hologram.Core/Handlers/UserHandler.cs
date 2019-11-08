using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Exceptions;
using Rbc.Hologram.Contracts.Interfaces.Handlers;
using Rbc.Hologram.Core.Mappers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rbc.Hologram.Core.Handlers
{
    public class UserHandler : IPrincipalHandler<UserDto>
    {
        private IUserContext uContext;
        public UserHandler(IUserContext uContext)
        {
            this.uContext = uContext;
        }

        public int Create(UserDto actionDto)
        {
            var user = new UserSearchHandler(uContext).Execute(new UserSearchRequest
            {
                Password = "",
                UserName = actionDto.UserName
            });

            if (user != null && user.Any())
                throw new DuplicateException("Duplicate user", "Already there is user exsisting for this credentials.");

            return uContext.Save(Mapper.Map(actionDto));
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserDto Read(int id)
        {
            var user = uContext.Get(id);

            if (user == null)
                throw new NotFoundException("Not found", $"There is no user for this {id} Id");

            return Mapper.Map(user);
        }

        public UserDto Read(int id, string[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDto> ReadAll()
        {
            throw new NotImplementedException();
        }

        public UserDto Update(int id, UserDto actiondto)
        {
            throw new NotImplementedException();
        }
    }
}
