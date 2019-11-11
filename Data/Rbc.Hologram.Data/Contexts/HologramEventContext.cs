using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class HologramEventContext : IHologramEventContext
    {
        public void Delete(int id)
        {
            using (var c = new CelebrityHologramContext())
            {
                var hEvent = Get(id);

                if (hEvent != null)
                {
                    hEvent.Deleted = true;
                    Update(hEvent);
                }
            }
        }

        public HologramEvent Get(int id)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.HologramEvent.FirstOrDefault(u => u.HologramEventId == id);
            }
        }

        public HologramEvent Get(string name)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.HologramEvent.FirstOrDefault(u => u.Name == name);
            }
        }

        public int Save(HologramEvent hEvent)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.HologramEvent.Add(hEvent);
                c.SaveChanges();
                return hEvent.HologramEventId;
            }
        }

        public HologramEvent Update(HologramEvent hEvent)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.HologramEvent.Update(hEvent);
                var id = c.SaveChanges();
                return hEvent;
            }
        }
    }
}
