using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.ContextInterfaces
{
    public interface ICelebrityHologramSearchContext
    {
        List<CelebrityHologramSearch> Get();
        CelebrityHologramSearch Get(int celebrityHologramId);
    }
}
