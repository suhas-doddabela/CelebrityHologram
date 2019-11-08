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
    public class CelebrityHandler : IPrincipalHandler<CelebrityDto>
    {
        private ICelebrityContext hContext;
        public CelebrityHandler(ICelebrityContext hContext)
        {
            this.hContext = hContext;
        }

        public int Create(CelebrityDto actionDto)
        {
            var celeb = hContext.Get(actionDto.FirstName, actionDto.LastName, actionDto.MiddleName);

            if (celeb != null)
                throw new DuplicateException("Duplicate celebrity", "Already there is celebrity exsisting for this credentials.");

            return hContext.Save(Mapper.Map(actionDto));
        }

        public void Delete(int id)
        {
            hContext.Delete(id);
        }

        public CelebrityDto Read(int id)
        {
            var hevent = hContext.Get(id);

            if (hevent == null)
                throw new NotFoundException("Not found", $"There is no celebrity for this {id} Id");

            return Mapper.Map(hevent);
        }

        public CelebrityDto Read(int id, string[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CelebrityDto> ReadAll()
        {
            throw new NotImplementedException();
        }

        public CelebrityDto Update(int id, CelebrityDto actiondto)
        {
            var hEvent = hContext.Update(Mapper.Map(actiondto));

            if (hEvent == null)
                throw new CelebrityHologramException("Db Exception", $"Not able to update celebrity {id}",
                    (int)HttpStatusCode.FailedDependency);

            return actiondto;
        }
    }
}
