using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Mappers
{
    public partial class Mapper
    {
        public static CelebrityHologramSearchResponse Map(CelebrityHologramSearch dto)
        {
            return new CelebrityHologramSearchResponse
            {
                Celebrity = Mapper.Map(dto.Celebrity),
                CelebrityHologramRefrence = $"CH{dto.Holograms.CelebrityHologramId}",
                HologramEvent = Mapper.Map(dto.HologramEvents)
            };
        }
    }
}
