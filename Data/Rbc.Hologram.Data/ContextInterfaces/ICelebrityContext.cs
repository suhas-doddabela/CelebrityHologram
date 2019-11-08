using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.ContextInterfaces
{
    public interface ICelebrityContext
    {
        Celebrity Get(int id);
        Celebrity Get(string firstname, string lastname, string middlename);
        int Save(Celebrity celeb);
        Celebrity Update(Celebrity celeb);
        void Delete(int id);
    }
}
