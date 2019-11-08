using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Mappers
{
    public partial class Mapper
    {
        public static HologramEventDto Map(HologramEvent hEvent)
        {
            return new HologramEventDto
            {
                CellPhone = hEvent.CellPhone,
                City = hEvent.City,
                Country = hEvent.Country,
                CreatedBy = hEvent.CreatedBy,
                DateCreated = hEvent.DateCreated,
                DateUpdated = hEvent.DateUpdated,
                Deleted = hEvent.Deleted,
                Description = hEvent.Description,
                Email = hEvent.Email,
                EventDate = hEvent.EventDate,
                HologramEventId = hEvent.HologramEventId,
                HologramTypeId = hEvent.HologramTypeId,
                LandPhone = hEvent.LandPhone,
                Name = hEvent.Name,
                Pincode = hEvent.Pincode,
                State = hEvent.State,
                StreetAddress = hEvent.StreetAddress,
                UpdatedBy = hEvent.UpdatedBy
            };
        }

        public static HologramEvent Map(HologramEventDto hEvent)
        {
            return new HologramEvent
            {
                CellPhone = hEvent.CellPhone,
                City = hEvent.City,
                Country = hEvent.Country,
                CreatedBy = hEvent.CreatedBy,
                DateCreated = hEvent.DateCreated,
                DateUpdated = hEvent.DateUpdated,
                Deleted = hEvent.Deleted,
                Description = hEvent.Description,
                Email = hEvent.Email,
                EventDate = hEvent.EventDate,
                HologramEventId = hEvent.HologramEventId,
                HologramTypeId = hEvent.HologramTypeId,
                LandPhone = hEvent.LandPhone,
                Name = hEvent.Name,
                Pincode = hEvent.Pincode,
                State = hEvent.State,
                StreetAddress = hEvent.StreetAddress,
                UpdatedBy = hEvent.UpdatedBy
            };
        }
    }
}
