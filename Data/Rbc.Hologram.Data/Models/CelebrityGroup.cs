using System;
using System.Collections.Generic;

namespace Rbc.Hologram.Data.Models
{
    public partial class CelebrityGroup
    {
        public int CelebrityGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? StillActive { get; set; }
        public DateTime? DateFormed { get; set; }
        public DateTime? DateEnded { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
