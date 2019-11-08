using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Rbc.Hologram.Contracts.Exceptions
{
    public class InvalidException : CelebrityHologramException
    {
        public InvalidException(string message, string description) : base(message, description, (int)HttpStatusCode.BadRequest)
        {
        }
    }
}
