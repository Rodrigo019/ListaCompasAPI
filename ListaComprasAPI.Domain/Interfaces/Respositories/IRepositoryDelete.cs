using ListaComprasAPI.Domain.Aggregations.Base;

namespace ListaComprasAPI.Domain.Interfaces.Respositories
{
    public interface IRepositoryDelete<T> where T : BaseModel
    {
        bool Delete(T model);
    }
}
