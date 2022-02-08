using ListaComprasAPI.Domain.Aggregations.Base;
using System.Collections.Generic;

namespace ListaComprasAPI.Domain.Interfaces.Services
{
    public interface IServiceSelectQuery<T,TArgs> 
        where T : BaseModel
        where TArgs : BaseArgs
    {
        List<T> SelectQuery(TArgs args);
    }
}
