using ListaComprasAPI.Domain.Aggregations.Base;

namespace ListaComprasAPI.Domain.Interfaces.Respositories
{
    public interface IRepositoryUpdate<T> where T : BaseModel
    {
        bool Update(T model);
    }
}
