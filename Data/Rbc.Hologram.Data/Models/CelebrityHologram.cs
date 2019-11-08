using System;
using System.Collections.Generic;

namespace Rbc.Hologram.Data.Models
{
    public partial class CelebrityHologram
    {
        public int CelebrityHologramId { get; set; }
        public int CelebrityId { get; set; }
        public int HologramEventId { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
