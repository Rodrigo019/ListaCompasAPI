using ListaComprasAPI.Domain.Aggregations.Base;

namespace ListaComprasAPI.Domain.Interfaces.Services
{
    public interface IServiceSelectById<T> 
        where T : BaseModel
    {
        T SelectById(long args);
    }
}
