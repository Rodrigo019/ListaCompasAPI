using ListaComprasAPI.Domain.Aggregations.Base;
using System.Collections.Generic;

namespace ListaComprasAPI.Domain.Interfaces.Respositories
{
    public interface IRepositorySelectQuery<T,TArgs> 
        where T : BaseModel
        where TArgs : BaseArgs
    {
        List<T> SelectQuery(TArgs args);
    }
}
