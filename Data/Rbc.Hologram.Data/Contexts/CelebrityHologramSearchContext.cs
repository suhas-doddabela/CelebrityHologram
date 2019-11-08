using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class CelebrityHologramSearchContext : ICelebrityHologramSearchContext
    {
        public List<CelebrityHologramSearch> Get()
        {
            using (var c = new CelebrityHologramContext())
            {
                var responses = (from ch in c.CelebrityHologram
                                 join h in c.HologramEvent on ch.HologramEventId equals h.HologramEventId
                                 join cl in c.Celebrity on ch.CelebrityId equals cl.CelebrityId
                                 select new CelebrityHologramSearch
                                 {
                                     HologramEvents = h,
                                     Holograms = ch,
                                     Celebrity = cl
                                 }

                                ).ToList();

                return responses;
            }
        }

        public CelebrityHologramSearch Get(int celebrityHologramId)
        {
            using (var c = new CelebrityHologramContext())
            {
                var response = (from ch in c.CelebrityHologram
                                 join h in c.HologramEvent on ch.HologramEventId equals h.HologramEventId
                                 join cl in c.Celebrity on ch.CelebrityId equals cl.CelebrityId
                                 where ch.CelebrityHologramId == celebrityHologramId
                                 select new CelebrityHologramSearch
                                 {
                                     HologramEvents = h,
                                     Holograms = ch,
                                     Celebrity = cl
                                 }

                                ).FirstOrDefault();

                return response;
            }
        }

    }
}
