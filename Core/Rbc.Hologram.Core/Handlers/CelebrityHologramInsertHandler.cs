using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Exceptions;
using Rbc.Hologram.Contracts.Interfaces.Handlers;
using Rbc.Hologram.Core.Mappers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Handlers
{
    public class CelebrityHologramInsertHandler : ICustomHandler<CelebrityHologramInsertRequest, CelebrityHologramInsertResponse>
    {
        private IHologramEventContext hContext;
        private ICelebrityContext cContext;
        private ICelebrityHologramContext chContext;
        public CelebrityHologramInsertHandler(ICelebrityContext cContext, IHologramEventContext hContext,
            ICelebrityHologramContext chContext)
        {
            this.hContext = hContext;
            this.cContext = cContext;
            this.chContext = chContext;
        }

        public CelebrityHologramInsertResponse Execute(CelebrityHologramInsertRequest request)
        {
            if(request.CelebrityId ==0)
            {
                if (request.Celebrity == null)
                    throw new BadRequestException("Bad request", "Either celebrityid or celebrity object is required.");

                request.CelebrityId = new CelebrityHandler(cContext).Create(request.Celebrity);
            }

            if(request.HologramEventId == 0)
            {
                if (request.HologramEvent == null)
                    throw new BadRequestException("Bad request", "Either hologrameventId or hologromevent object is required.");

                request.HologramEventId = new HologramEventHandler(hContext).Create(request.HologramEvent);
            }

            var id = chContext.Save(new Data.Models.CelebrityHologram
            {
                CelebrityId = request.CelebrityId,
                HologramEventId = request.HologramEventId,
                CreatedBy = "API",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                UpdatedBy = "API",
                Deleted = false
            });

            return new CelebrityHologramInsertResponse { CelebrityHologramRefrence = $"CH{id}" };
        }
    }
}
