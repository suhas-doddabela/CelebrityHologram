using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Mappers
{
    public partial class Mapper
    {
        public static CelebrityGroupDto Map(CelebrityGroup group)
        {
            return new CelebrityGroupDto
            {
                CelebrityGroupId = group.CelebrityGroupId,
                CreatedBy = group.CreatedBy,
                DateCreated = group.DateCreated,
                DateEnded = group.DateEnded,
                DateFormed = group.DateFormed,
                DateUpdated = group.DateUpdated,
                Description = group.Description,
                Name = group.Name,
                StillActive = group.StillActive,
                UpdatedBy = group.UpdatedBy
            };
        }

        public static CelebrityGroup Map(CelebrityGroupDto group)
        {
            return new CelebrityGroup
            {
                CelebrityGroupId = group.CelebrityGroupId,
                CreatedBy = group.CreatedBy,
                DateCreated = group.DateCreated,
                DateEnded = group.DateEnded,
                DateFormed = group.DateFormed,
                DateUpdated = group.DateUpdated,
                Description = group.Description,
                Name = group.Name,
                StillActive = group.StillActive,
                UpdatedBy = group.UpdatedBy
            };
        }
    }
}
