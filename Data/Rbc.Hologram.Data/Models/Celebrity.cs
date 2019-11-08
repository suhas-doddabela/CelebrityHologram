using System;
using System.Collections.Generic;

namespace Rbc.Hologram.Data.Models
{
    public partial class Celebrity
    {
        public int CelebrityId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string StreetAdress { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DeceasedDate { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }

        public string LandPhone { get; set; }
        public int CelebrityIndustryId { get; set; }
        public int? CelebrityGroupId { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
