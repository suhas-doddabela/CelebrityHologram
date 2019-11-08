using Rbc.Hologram.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Interfaces.Contracts
{
    public interface IHologramEventContract 
    {
        int Post(HologramEventDto actionDto);
        HologramEventDto Get(int id);
        HologramEventDto Put(int id, HologramEventDto actiondto);
        void Delete(int id);
    }
}
