using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.ContextInterfaces
{
    public interface IHologramEventContext
    {
        HologramEvent Get(int id);
        HologramEvent Get(string name);
        int Save(HologramEvent hEvent);
        HologramEvent Update(HologramEvent hEvent);
        void Delete(int id);
    }
}
