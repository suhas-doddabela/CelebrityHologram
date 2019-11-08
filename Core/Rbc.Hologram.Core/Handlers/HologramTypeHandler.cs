using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Interfaces.Handlers;
using Rbc.Hologram.Core.Mappers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Core.Handlers
{
    public class HologramTypeHandler : IPrincipalHandler<HologramTypeDto>
    {
        private IHologramTypeContext hContext;
        public HologramTypeHandler(IHologramTypeContext hContext)
        {
            this.hContext = hContext;
        }

        public int Create(HologramTypeDto actionDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public HologramTypeDto Read(int id)
        {
            throw new NotImplementedException();
        }

        public HologramTypeDto Read(int id, string[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HologramTypeDto> ReadAll()
        {
            return hContext.GetAll().Select(Mapper.Map);
        }

        public HologramTypeDto Update(int id, HologramTypeDto actiondto)
        {
            throw new NotImplementedException();
        }
    }
}
