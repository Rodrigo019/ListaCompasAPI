using ListaComprasAPI.Domain.Aggregations.Base;

namespace ListaComprasAPI.Domain.Interfaces.Services
{
    public interface IServiceInsert<T> where T : BaseModel
    {
        bool Insert(T model);
    }
}
