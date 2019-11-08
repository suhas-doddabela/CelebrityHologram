using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.ContextInterfaces
{
    public interface IHologramTypeContext
    {
        List<Models.HologramType> GetAll();
    }
}
