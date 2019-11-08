using Rbc.Hologram.Contracts.Dtos;
using Rbc.Hologram.Contracts.Enum;
using Rbc.Hologram.Contracts.Exceptions;
using Rbc.Hologram.Contracts.Interfaces.Handlers;
using Rbc.Hologram.Core.Mappers;
using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rbc.Hologram.Core.Handlers
{
    public class CelebrityHologramSearchHandler : ICustomHandler<CelebrityHologramSearchRequest, List<CelebrityHologramSearchResponse>>
    {

        private ICelebrityHologramSearchContext cContext;
        
        public CelebrityHologramSearchHandler(ICelebrityHologramSearchContext cContext)
        {
            this.cContext = cContext;
        }

        public List<CelebrityHologramSearchResponse> Execute(CelebrityHologramSearchRequest request)
        {
            var responses = new List<CelebrityHologramSearchResponse>();
           switch (request.SearchType)
            {
                case CelebrityHologramSearchTypes.All:
                    responses.AddRange(cContext.Get().Select(Mapper.Map));
                    break;

                case CelebrityHologramSearchTypes.Specific:
                    if (string.IsNullOrEmpty(request.CelebrityHologramRefrence))
                        throw new BadRequestException("Required", 
                            "CelebrityHologramRefrence is required for specific search");

                    var refrence = request.CelebrityHologramRefrence.Replace("CH", string.Empty);
                    var refId = 0;

                    if (!int.TryParse(refrence, out refId))
                        throw new InvalidException("Invalid",
                            $"The provided refrence number {request.CelebrityHologramRefrence} is invalid.");

                    var response = cContext.Get(refId);

                    if(response == null)
                        throw new NotFoundException("Not found",
                                    $"The celebrity hologram is not avaialble for the provided referene {request.CelebrityHologramRefrence}");

                    responses.Add(Mapper.Map(response));
                    break;
            }

            return responses;
        }
    
    }
}
