using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Rbc.Hologram.Contracts.Exceptions
{
    public class BadRequestException : CelebrityHologramException
    {
        public BadRequestException(string message, string description) : base(message, description, (int)HttpStatusCode.BadRequest)
        {
        }
    }
}
