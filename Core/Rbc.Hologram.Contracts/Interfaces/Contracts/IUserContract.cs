using Rbc.Hologram.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Interfaces.Contracts
{
    public interface IUserContract
    {
        int Post(UserDto actionDto);
        UserDto Get(int id);
        List<UserDto> Search(UserSearchRequest request);
        UserAuthenticationResponse Authenticate(UserAuthenticationRequest request);
    }
}
