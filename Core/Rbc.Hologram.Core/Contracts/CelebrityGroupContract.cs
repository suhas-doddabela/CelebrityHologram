using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Interfaces.Contracts;
using Rbc.Hologram.Core.Handlers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Contracts
{
    public class CelebrityGroupContract : ICelebrityGroupContract
    {
        private ICelebrityGroupContext hContext;
        public CelebrityGroupContract(ICelebrityGroupContext context)
        {
            hContext = context;
        }


        public CelebrityGroupDto Get(int id)
        {
            return new CelebrityGroupHandler(hContext).Read(id);
        }

        public IEnumerable<CelebrityGroupDto> Get()
        {
            return new CelebrityGroupHandler(hContext).ReadAll();
        }

        public int Post(CelebrityGroupDto actionDto)
        {
            return new CelebrityGroupHandler(hContext).Create(actionDto);
        }

        public CelebrityGroupDto Put(int id, CelebrityGroupDto actiondto)
        {
            return new CelebrityGroupHandler(hContext).Update(id, actiondto);
        }
    }
}
