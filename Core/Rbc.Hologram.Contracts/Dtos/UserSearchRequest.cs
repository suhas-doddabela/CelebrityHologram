using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Dtos
{
    public class UserSearchRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
