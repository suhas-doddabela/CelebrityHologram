using System;
using System.Collections.Generic;

namespace Rbc.Hologram.Data.Models
{
    public partial class HologramEvent
    {
        public int HologramEventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StreetAddress { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public DateTime? EventDate { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string LandPhone { get; set; }
        public int? HologramTypeId { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
