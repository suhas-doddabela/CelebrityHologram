using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Mappers
{
    public partial class Mapper
    {
        public static CelebrityIndustryDto Map(CelebrityIndustry cIndus)
        {
            return new CelebrityIndustryDto
            {
                UpdatedBy = cIndus.UpdatedBy,
                Description = cIndus.Description,
                Name = cIndus.Name,
                CelebrityIndustryId = cIndus.CelebrityIndustryId,
                CreatedBy = cIndus.CreatedBy,
                DateCreated = cIndus.DateCreated,
                DateUpdated = cIndus.DateUpdated
            };
        }

        public static CelebrityIndustry Map(CelebrityIndustryDto cIndus)
        {
            return new CelebrityIndustry
            {
                UpdatedBy = cIndus.UpdatedBy,
                Description = cIndus.Description,
                Name = cIndus.Name,
                CelebrityIndustryId = cIndus.CelebrityIndustryId,
                CreatedBy = cIndus.CreatedBy,
                DateCreated = cIndus.DateCreated,
                DateUpdated = cIndus.DateUpdated
            };
        }
    }
}
