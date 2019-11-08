using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Interfaces.Handlers
{
    public interface IPrincipalHandler<TDto>
    {
        TDto Read(int id);
        int Create(TDto actionDto);
        TDto Update(int id, TDto actiondto);
        void Delete(int id);
        TDto Read(int id, string[] includes);
        //Tdto Pacth(int id, Tdto actionDto);
        IEnumerable<TDto> ReadAll();
        // TDto Read(string id);

    }
}
