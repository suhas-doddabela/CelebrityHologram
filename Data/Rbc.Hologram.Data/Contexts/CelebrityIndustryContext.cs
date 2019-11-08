using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class CelebrityIndustryContext : ICelebrityIndustryContext
    {
        public CelebrityIndustry Get(int id)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.CelebrityIndustry.FirstOrDefault(u => u.CelebrityIndustryId == id);
            }
        }

        public CelebrityIndustry Get(string name)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.CelebrityIndustry.FirstOrDefault(u => u.Name == name);
            }
        }

        public List<CelebrityIndustry> Get()
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.CelebrityIndustry.ToList();
            }
        }

        public int Save(CelebrityIndustry celebIndustry)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.CelebrityIndustry.Add(celebIndustry);
                return c.SaveChanges();
            }
        }

        public CelebrityIndustry Update(CelebrityIndustry celebIndustry)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.CelebrityIndustry.Update(celebIndustry);
                var id = c.SaveChanges();
                return celebIndustry;
            }
        }
    }
}
