using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.ContextInterfaces
{
    public interface ICelebrityIndustryContext
    {
        List<CelebrityIndustry> Get();
        CelebrityIndustry Get(int id);
        CelebrityIndustry Get(string name);
        int Save(CelebrityIndustry celebIndustry);
        CelebrityIndustry Update(CelebrityIndustry celebIndustry);
    }
}
