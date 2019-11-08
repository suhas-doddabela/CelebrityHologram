using Rbc.Hologram.Contracts.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Dtos
{
    public class CelebrityHologramSearchRequest
    {
        public string CelebrityHologramRefrence { get; set; }
        public CelebrityHologramSearchTypes SearchType { get; set; }
    }
}
