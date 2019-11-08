using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Interfaces.Contracts;
using Rbc.Hologram.Core.Handlers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Contracts
{
    public class CelebrityContract : ICelebrityContract
    {
        private ICelebrityContext hContext;
        public CelebrityContract(ICelebrityContext context)
        {
            hContext = context;
        }

        public void Delete(int id)
        {
            new CelebrityHandler(hContext).Delete(id);
        }

        public CelebrityDto Get(int id)
        {
            return new CelebrityHandler(hContext).Read(id);
        }

        public int Post(CelebrityDto actionDto)
        {
            return new CelebrityHandler(hContext).Create(actionDto);
        }

        public CelebrityDto Put(int id, CelebrityDto actiondto)
        {
            return new CelebrityHandler(hContext).Update(id, actiondto);
        }
    }
}
