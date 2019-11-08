using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.ContextInterfaces
{
    public interface ICelebrityHologramContext
    {
        CelebrityHologram Get(int id);
        int Save(CelebrityHologram celebHologram);
        void Delete(int id);
        CelebrityHologram Update(CelebrityHologram celebHologram);
    }
}
