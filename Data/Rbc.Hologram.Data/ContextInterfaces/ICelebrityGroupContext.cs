using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.ContextInterfaces
{
    public interface ICelebrityGroupContext
    {
        List<CelebrityGroup> Get();
        CelebrityGroup Get(int id);
        CelebrityGroup Get(string name);
        int Save(CelebrityGroup celebGroup);
        CelebrityGroup Update(CelebrityGroup celebGroup);
    }
}
