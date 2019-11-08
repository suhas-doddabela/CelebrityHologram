using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class CelebrityContext : ICelebrityContext
    {
        public void Delete(int id)
        {
            using (var c = new CelebrityHologramContext())
            {
                var celeb = Get(id);

                if (celeb != null)
                {
                    celeb.Deleted = true;
                    Update(celeb);
                }
            }
        }

        public Celebrity Get(int id)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.Celebrity.FirstOrDefault(u => u.CelebrityId == id);
            }
        }

        public Celebrity Get(string firstname, string lastname, string middlename)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.Celebrity.FirstOrDefault(u => u.FirstName == firstname &&
                    u.LastName == lastname && u.MiddleName == middlename);
            }
        }

        public int Save(Celebrity celeb)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.Celebrity.Add(celeb);
                return c.SaveChanges();
            }
        }

        public Celebrity Update(Celebrity celeb)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.Celebrity.Update(celeb);
                var id = c.SaveChanges();
                return celeb;
            }
        }
    }
}
