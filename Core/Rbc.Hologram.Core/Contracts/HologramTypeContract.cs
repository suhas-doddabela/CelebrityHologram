using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Interfaces.Contracts;
using Rbc.Hologram.Core.Handlers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Contracts
{
    public class HologramTypeContract : IHologramTypeContract
    {
        private IHologramTypeContext hContext;
        public HologramTypeContract(IHologramTypeContext context)
        {
            hContext = context;
        }

        public IEnumerable<HologramTypeDto> GetAll()
        {
            return new HologramTypeHandler(hContext).ReadAll();
        }
    }
}
