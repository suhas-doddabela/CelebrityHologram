using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class CelebrityGroupContext : ICelebrityGroupContext
    {
        public CelebrityGroup Get(int id)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.CelebrityGroup.FirstOrDefault(u => u.CelebrityGroupId == id);
            }
        }

        public CelebrityGroup Get(string name)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.CelebrityGroup.FirstOrDefault(u => u.Name == name);
            }
        }

        public List<CelebrityGroup> Get()
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.CelebrityGroup.ToList();
            }
        }

        public int Save(CelebrityGroup celebGroup)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.CelebrityGroup.Add(celebGroup);
                return c.SaveChanges();
            }
        }

        public CelebrityGroup Update(CelebrityGroup celebGroup)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.CelebrityGroup.Update(celebGroup);
                var id = c.SaveChanges();
                return celebGroup;
            }
        }
    }
}
