using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Mappers
{
    public partial class Mapper
    {
        public static HologramTypeDto Map(HologramType htype)
        {
            return new HologramTypeDto
            {
                CreatedBy = htype.CreatedBy,
                DateCreated = htype.DateCreated,
                DateUpdated = htype.DateUpdated,
                Description = htype.Description,
                HologramTypeId = htype.HologramTypeId,
                Name = htype.Name,
                UpdatedBy = htype.UpdatedBy
            };
        }

        public static HologramType Map(HologramTypeDto htype)
        {
            return new HologramType
            {
                CreatedBy = htype.CreatedBy,
                DateCreated = htype.DateCreated,
                DateUpdated = htype.DateUpdated,
                Description = htype.Description,
                HologramTypeId = htype.HologramTypeId,
                Name = htype.Name,
                UpdatedBy = htype.UpdatedBy
            };
        }
    }
}
