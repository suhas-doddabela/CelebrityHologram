using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Exceptions;
using Rbc.Hologram.Contracts.Interfaces.Handlers;
using Rbc.Hologram.Core.Mappers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Rbc.Hologram.Core.Handlers
{
    public class HologramEventHandler : IPrincipalHandler<HologramEventDto>
    {
        private IHologramEventContext hContext;
        public HologramEventHandler(IHologramEventContext hContext)
        {
            this.hContext = hContext;
        }

        public int Create(HologramEventDto actionDto)
        {
            var hevent = hContext.Get(actionDto.Name);

            if (hevent != null)
                throw new DuplicateException("Duplicate user", "Already there is user exsisting for this credentials.");

            return hContext.Save(Mapper.Map(actionDto));
        }

        public void Delete(int id)
        {
            hContext.Delete(id);
        }

        public HologramEventDto Read(int id)
        {
            var hevent = hContext.Get(id);

            if (hevent == null)
                throw new NotFoundException("Not found", $"There is no event for this {id} Id");

            return Mapper.Map(hevent);
        }

        public HologramEventDto Read(int id, string[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HologramEventDto> ReadAll()
        {
            throw new NotImplementedException();
        }

        public HologramEventDto Update(int id, HologramEventDto actiondto)
        { 
            var hEvent = hContext.Update(Mapper.Map(actiondto));

            if (hEvent == null)
                throw new CelebrityHologramException("Db Exception", $"Not able to update event {id}", 
                    (int)HttpStatusCode.FailedDependency);

            return actiondto;
        }
    }
}
