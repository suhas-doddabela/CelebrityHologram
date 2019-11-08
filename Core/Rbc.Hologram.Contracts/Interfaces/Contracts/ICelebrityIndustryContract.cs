using Rbc.Hologram.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Interfaces.Contracts
{
    public interface ICelebrityIndustryContract
    {
        int Post(CelebrityIndustryDto actionDto);
        CelebrityIndustryDto Get(int id);
        IEnumerable<CelebrityIndustryDto> Get();
        CelebrityIndustryDto Put(int id, CelebrityIndustryDto actiondto);
    }
}
