using Rbc.Hologram.Data.Contexts;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class HologramTypeContext : IHologramTypeContext
    {
        public List<Models.HologramType> GetAll()
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.HologramType.ToList();
            }
        }
    }
}
