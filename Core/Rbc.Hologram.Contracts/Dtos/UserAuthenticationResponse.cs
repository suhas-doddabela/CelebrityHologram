using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Dtos
{
    public class UserAuthenticationResponse
    {
        public string Token { get; set; }
        public string UserName { get; set; }
    }
}
