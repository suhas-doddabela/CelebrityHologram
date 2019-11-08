using Rbc.Hologram.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Interfaces.Contracts
{
    public interface ICelebrityContract
    {
        int Post(CelebrityDto actionDto);
        CelebrityDto Get(int id);
        CelebrityDto Put(int id, CelebrityDto actiondto);
        void Delete(int id);
    }
}
