using Rbc.Hologram.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Interfaces.Contracts
{
    public interface ICelebrityGroupContract
    {
        int Post(CelebrityGroupDto actionDto);
        CelebrityGroupDto Get(int id);
        IEnumerable<CelebrityGroupDto> Get();
        CelebrityGroupDto Put(int id, CelebrityGroupDto actiondto);
    }
}
