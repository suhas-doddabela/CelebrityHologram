using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class CelebrityHologramsContext : ICelebrityHologramContext
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

        public CelebrityHologram Get(int id)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.CelebrityHologram.FirstOrDefault(u => u.CelebrityHologramId == id);
            }
        }
    

        public int Save(CelebrityHologram celebHologram)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.CelebrityHologram.Add(celebHologram);
                return c.SaveChanges();
            }
        }

        public CelebrityHologram Update(CelebrityHologram celebHologram)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.CelebrityHologram.Update(celebHologram);
                var id = c.SaveChanges();
                return celebHologram;
            }
        }
    }
}
