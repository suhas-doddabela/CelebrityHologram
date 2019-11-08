using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class ContextSeeder
    {
        public static void Seed(CelebrityHologramContext context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (!context.User.Any())
            {
                context.User.Add(
                    new Models.User
                    {
                        CreatedBy = "Suhas",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        Password = "test@123Y",
                        UpdatedBy = "Suhas",
                        UserName = "SuhasTest1"
                    });
                context.User.Add(
                   new Models.User
                   {
                       CreatedBy = "Suhas",
                       DateCreated = DateTime.Now,
                       DateUpdated = DateTime.Now,
                       Password = "test@1234Y",
                       UpdatedBy = "Suhas",
                       UserName = "SuhasTest2"
                   });
            }

            if (!context.HologramType.Any())
            {
                context.HologramType.Add(new Models.HologramType
                {
                    CreatedBy = "Suhas",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "Suhas",
                    Description = "Light is shone through the hologram",
                    Name = "Transmission"
                });

                context.HologramType.Add(new Models.HologramType
                {
                    CreatedBy = "Suhas",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "Suhas",
                    Description = "The hologram reflects light",
                    Name = "Reflection "
                });
            }

            context.SaveChanges();
        }
    }
}
