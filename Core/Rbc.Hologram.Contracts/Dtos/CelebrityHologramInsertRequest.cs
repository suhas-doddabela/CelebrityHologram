using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Dtos
{
    public class CelebrityHologramInsertRequest
    {
        public int CelebrityId { get; set; }
        public int HologramEventId { get; set; }
        public HologramEventDto HologramEvent { get; set; }
        public CelebrityDto Celebrity { get; set; }
    }
}
