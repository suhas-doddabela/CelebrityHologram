using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Interfaces.Contracts;
using Rbc.Hologram.Core.Handlers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Contracts
{
    public class CelebrityHologramContract : ICelebrityHologramContract
    {       
        private IHologramEventContext hContext;
        private ICelebrityContext cContext;
        private ICelebrityHologramContext chContext;
        private ICelebrityHologramSearchContext chsContext;

        public CelebrityHologramContract(IHologramEventContext hContext,
            ICelebrityContext cContext, ICelebrityHologramContext chContext, ICelebrityHologramSearchContext chsContext)
        {
            this.hContext = hContext;
            this.cContext = cContext;
            this.chContext = chContext;
            this.chsContext = chsContext;
        }

        public CelebrityHologramInsertResponse Delete(CelebrityHologramDeleteRequest request)
        {
            return new CelebrityHologramDeleteHandler(hContext, chContext).Execute(request);
        }

        public CelebrityHologramInsertResponse Insert(CelebrityHologramInsertRequest request)
        {
            return new CelebrityHologramInsertHandler(cContext, hContext, chContext).Execute(request);
        }

        public List<CelebrityHologramSearchResponse> Search(CelebrityHologramSearchRequest request)
        {
            return new CelebrityHologramSearchHandler(chsContext).Execute(request);
        }
    }
}
