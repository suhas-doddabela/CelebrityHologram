using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Interfaces.Contracts;
using Rbc.Hologram.Core.Handlers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Contracts
{
    public class CelebrityIndustryContract : ICelebrityIndustryContract
    {
        private ICelebrityIndustryContext hContext;
        public CelebrityIndustryContract(ICelebrityIndustryContext context)
        {
            hContext = context;
        }

        public CelebrityIndustryDto Get(int id)
        {
            return new CelebrityIndustryHandler(hContext).Read(id);
        }

        public IEnumerable<CelebrityIndustryDto> Get()
        {
            return new CelebrityIndustryHandler(hContext).ReadAll();
        }

        public int Post(CelebrityIndustryDto actionDto)
        {
            return new CelebrityIndustryHandler(hContext).Create(actionDto);
        }

        public CelebrityIndustryDto Put(int id, CelebrityIndustryDto actiondto)
        {
            return new CelebrityIndustryHandler(hContext).Update(id, actiondto);
        }
    }
}
