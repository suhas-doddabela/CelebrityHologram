using Rbc.Hologram.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Interfaces.Contracts
{
    public interface ICelebrityHologramContract
    {
        List<CelebrityHologramSearchResponse> Search(CelebrityHologramSearchRequest request);
        CelebrityHologramInsertResponse Insert(CelebrityHologramInsertRequest request);
        CelebrityHologramInsertResponse Delete(CelebrityHologramDeleteRequest request);
    }
}
