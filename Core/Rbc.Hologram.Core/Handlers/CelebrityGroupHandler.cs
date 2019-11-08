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
    public class CelebrityGroupHandler : IPrincipalHandler<CelebrityGroupDto>
    {

        private ICelebrityGroupContext hContext;
        public CelebrityGroupHandler(ICelebrityGroupContext hContext)
        {
            this.hContext = hContext;
        }

        public int Create(CelebrityGroupDto actionDto)
        {
            var celeb = hContext.Get(actionDto.Name);

            if (celeb != null)
                throw new DuplicateException("Duplicate celebrity group", "Already there is celebrity group exsisting for this credentials.");

            return hContext.Save(Mapper.Map(actionDto));
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CelebrityGroupDto Read(int id)
        {
            var cg = hContext.Get(id);

            if (cg == null)
                throw new NotFoundException("Not found", $"There is no celebrity group for this {id} Id");

            return Mapper.Map(cg);
        }

        public CelebrityGroupDto Read(int id, string[] includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CelebrityGroupDto> ReadAll()
        {
            var cgs = hContext.Get();

            if(cgs == null || !cgs.Any())
                throw new NotFoundException("Not found", $"There is no celebrity groups");

            return cgs.Select(Mapper.Map);
        }

        public CelebrityGroupDto Update(int id, CelebrityGroupDto actiondto)
        {
            var cg = hContext.Update(Mapper.Map(actiondto));

            if (cg == null)
                throw new CelebrityHologramException("Db Exception", $"Not able to update celebrity group {id}",
                    (int)HttpStatusCode.FailedDependency);

            return actiondto;
        }
    }
}
