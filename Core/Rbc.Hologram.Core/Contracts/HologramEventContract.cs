using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Interfaces.Contracts;
using Rbc.Hologram.Core.Handlers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Contracts
{
    public class HologramEventContract : IHologramEventContract
    {
        private IHologramEventContext hContext;
        public HologramEventContract(IHologramEventContext context)
        {
            hContext = context;
        }


        public void Delete(int id)
        {
            new HologramEventHandler(hContext).Delete(id);
        }

        public HologramEventDto Get(int id)
        {
            return new HologramEventHandler(hContext).Read(id);
        }

        public int Post(HologramEventDto actionDto)
        {
            return new HologramEventHandler(hContext).Create(actionDto);
        }

        public HologramEventDto Put(int id, HologramEventDto actiondto)
        {
            return new HologramEventHandler(hContext).Update(id, actiondto);
        }
    }
}
