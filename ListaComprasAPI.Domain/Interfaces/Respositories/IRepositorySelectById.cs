using ListaComprasAPI.Domain.Aggregations.Base;

namespace ListaComprasAPI.Domain.Interfaces.Respositories
{
    public interface IRepositorySelectById<T> 
        where T : BaseModel
    {
        T SelectById(long args);
    }
}
