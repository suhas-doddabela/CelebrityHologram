using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Rbc.Hologram.Contracts.Exceptions
{
    public class NotFoundException : CelebrityHologramException
    {
        public NotFoundException(string message, string description) : base(message, description, (int)HttpStatusCode.NotFound)
        {
        }
    }
}
