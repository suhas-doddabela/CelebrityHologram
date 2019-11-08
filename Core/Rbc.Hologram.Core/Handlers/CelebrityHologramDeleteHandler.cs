using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Exceptions;
using Rbc.Hologram.Contracts.Interfaces.Handlers;
using Rbc.Hologram.Data.ContextInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Core.Handlers
{
    public class CelebrityHologramDeleteHandler : ICustomHandler<CelebrityHologramDeleteRequest, CelebrityHologramInsertResponse>
    {
        private IHologramEventContext hContext;
        private ICelebrityHologramContext chContext;
        public CelebrityHologramDeleteHandler(IHologramEventContext hContext,
            ICelebrityHologramContext chContext)
        {
            this.hContext = hContext;
            this.chContext = chContext;
        }

        public CelebrityHologramInsertResponse Execute(CelebrityHologramDeleteRequest request)
        {
            var refrence = request.CelebrityHologramRefrence.Replace("CH", string.Empty);
            var refId = 0;

            if (!int.TryParse(refrence, out refId))
                throw new InvalidException("Invalid", 
                    $"The provided refrence number {request.CelebrityHologramRefrence} is invalid.");

            var chEvent = chContext.Get(int.Parse(refrence));

            if (chEvent == null)
                throw new NotFoundException("Not found",
                    $"The celebrity hologram is not avaialble for the provided referene {request.CelebrityHologramRefrence}");

            chContext.Delete(refId);

            new HologramEventHandler(hContext).Delete(chEvent.CelebrityId);

            return new CelebrityHologramInsertResponse { CelebrityHologramRefrence = request.CelebrityHologramRefrence };

        }
    }
}
