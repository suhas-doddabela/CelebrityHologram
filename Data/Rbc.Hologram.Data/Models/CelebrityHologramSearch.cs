using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.Models
{
    public class CelebrityHologramSearch
    {
        public CelebrityHologram Holograms { get; set; }
        public Celebrity Celebrity { get; set; }
        public HologramEvent HologramEvents {get; set;}
    }
}
