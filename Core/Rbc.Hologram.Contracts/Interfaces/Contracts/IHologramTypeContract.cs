using Rbc.Hologram.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Interfaces.Contracts
{
    public interface IHologramTypeContract
    {
        IEnumerable<HologramTypeDto> GetAll();
    }
}
