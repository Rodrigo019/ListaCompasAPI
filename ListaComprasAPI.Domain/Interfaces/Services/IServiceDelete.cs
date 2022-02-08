using ListaComprasAPI.Domain.Aggregations.Base;

namespace ListaComprasAPI.Domain.Interfaces.Services
{
    public interface IServiceDelete<T> where T : BaseModel
    {
        bool Delete(T model);
    }
}
