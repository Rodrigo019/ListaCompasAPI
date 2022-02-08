using ListaComprasAPI.Domain.Aggregations.Base;

namespace ListaComprasAPI.Domain.Interfaces.Respositories
{
    public interface IRepositoryInsert<T> where T : BaseModel
    {
        bool Insert(T model);
    }
}
