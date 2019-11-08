using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Rbc.Hologram.Contracts.Exceptions
{
    public class AuthenticationFailedException : CelebrityHologramException
    {
        public AuthenticationFailedException(string message, string description) : base(message, description, (int)HttpStatusCode.Unauthorized)
        {
        }
    }
}
