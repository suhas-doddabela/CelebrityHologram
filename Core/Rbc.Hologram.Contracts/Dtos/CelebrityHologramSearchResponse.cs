using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Dtos
{
    public class CelebrityHologramSearchResponse
    {
        public string CelebrityHologramRefrence { get; set; }
        public CelebrityDto Celebrity { get; set; } 
        public HologramEventDto HologramEvent { get; set; }
    }
}
