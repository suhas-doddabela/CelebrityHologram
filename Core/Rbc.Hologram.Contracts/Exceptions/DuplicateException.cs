using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Rbc.Hologram.Contracts.Exceptions
{
    public class DuplicateException : CelebrityHologramException
    {
        public DuplicateException(string message, string description) : base(message, description, (int)HttpStatusCode.Conflict)
        {
        }
    }
}
