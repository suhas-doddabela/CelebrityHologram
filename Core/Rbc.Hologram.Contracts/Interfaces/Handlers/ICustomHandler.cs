using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Contracts.Interfaces.Handlers
{
    public interface ICustomHandler<TRequest,TResponse>
    {
        TResponse Execute(TRequest request);
    }
}
