using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Mappers
{
    public partial class Mapper
    {
        public static UserDto Map(User user)
        {
            return new UserDto
            {
                Password = user.Password,
                CreatedBy = user.CreatedBy,
                DateCreated = user.DateCreated,
                DateUpdated = user.DateUpdated,
                UpdatedBy = user.UpdatedBy,
                UserId = user.UserId,
                UserName = user.UserName
            };
        }

        public static User Map(UserDto user)
        {
            return new User
            {
                Password = user.Password,
                CreatedBy = user.CreatedBy,
                DateCreated = user.DateCreated,
                DateUpdated = user.DateUpdated,
                UpdatedBy = user.UpdatedBy,
                UserId = user.UserId,
                UserName = user.UserName
            };
        }
    }
}
