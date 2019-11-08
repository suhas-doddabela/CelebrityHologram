using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Exceptions
{
    public class CelebrityHologramException : Exception
    {
        private int code;
        private string description;

        public int Code
        {
            get => code;
        }
        public string Description
        {
            get => description;
        }

        public CelebrityHologramException(string message, string description, int code) : base(message)
        {
            this.code = code;
            this.description = description;
        }
    }
}
