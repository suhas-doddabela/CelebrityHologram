using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Mappers
{
    public partial class Mapper
    {
        public static CelebrityDto Map(Celebrity celeb)
        {
            return new CelebrityDto
            {
                MiddleName = celeb.MiddleName,
                LastName = celeb.LastName,
                LandPhone = celeb.LandPhone,
                FirstName = celeb.FirstName,
                BirthDate = celeb.BirthDate,
                CelebrityGroupId = celeb.CelebrityGroupId,
                CelebrityId = celeb.CelebrityId,
                CelebrityIndustryId = celeb.CelebrityIndustryId,
                CellPhone = celeb.CellPhone,
                City = celeb.City,
                Country = celeb.Country,
                CreatedBy = celeb.CreatedBy,
                DateCreated = celeb.DateCreated,
                DeceasedDate = celeb.DeceasedDate,
                Deleted = celeb.Deleted,
                Email = celeb.Email,
                Pincode = celeb.Pincode,
                State = celeb.State,
                StreetAdress = celeb.StreetAdress,
                UpdatedBy = celeb.UpdatedBy,
                DateUpdated = celeb.DateUpdated,
            };
        }

        public static Celebrity Map(CelebrityDto celeb)
        {
            return new Celebrity
            {
                MiddleName = celeb.MiddleName,
                LastName = celeb.LastName,
                LandPhone = celeb.LandPhone,
                FirstName = celeb.FirstName,
                BirthDate = celeb.BirthDate,
                CelebrityGroupId = celeb.CelebrityGroupId,
                CelebrityId = celeb.CelebrityId,
                CelebrityIndustryId = celeb.CelebrityIndustryId,
                CellPhone = celeb.CellPhone,
                City = celeb.City,
                Country = celeb.Country,
                CreatedBy = celeb.CreatedBy,
                DateCreated = celeb.DateCreated,
                DeceasedDate = celeb.DeceasedDate,
                Deleted = celeb.Deleted,
                Email = celeb.Email,
                Pincode = celeb.Pincode,
                State = celeb.State,
                StreetAdress = celeb.StreetAdress,
                UpdatedBy = celeb.UpdatedBy,
                DateUpdated = celeb.DateUpdated,
            };
        }
    }
}
