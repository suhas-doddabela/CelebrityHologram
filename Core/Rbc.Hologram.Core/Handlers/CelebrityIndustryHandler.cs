using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Exceptions;
using Rbc.Hologram.Contracts.Interfaces.Handlers;
using Rbc.Hologram.Core.Mappers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Rbc.Hologram.Core.Handlers
{
    public class CelebrityIndustryHandler : IPrincipalHandler<CelebrityIndustryDto>
    {
        private ICelebrityIndustryContext hContext;
        public CelebrityIndustryHandler(ICelebrityIndustryContext hContext)
        {
            this.hContext = hContext;
        }

        public int Create(CelebrityIndustryDto actionDto)
        {
            var celeb = hContext.Get(actionDto.Name);

            if (celeb != null)
                throw new DuplicateException("Duplicate celebrity industry", "Already there is celebrity industry exsisting for this credentials.");

            return hContext.Save(Mapper.Map(actionDto));
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CelebrityIndustryDto Read(int id)
        {
            var cg = hContext.Get(id);

            if (cg == null)
                throw new NotFoundException("Not found", $"There is no celebrity group for this {id} Id");

            return Mapper.Map(cg);
        }

        public CelebrityIndustryDto Read(int id, string[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CelebrityIndustryDto> ReadAll()
        {
            var cgs = hContext.Get();

            if (cgs == null || !cgs.Any())
                throw new NotFoundException("Not found", $"There is no celebrity groups");

            return cgs.Select(Mapper.Map);
        }

        public CelebrityIndustryDto Update(int id, CelebrityIndustryDto actiondto)
        {
            var cg = hContext.Update(Mapper.Map(actiondto));

            if (cg == null)
                throw new CelebrityHologramException("Db Exception", $"Not able to update celebrity group {id}",
                    (int)HttpStatusCode.FailedDependency);

            return actiondto;
        }
    }
}
