using ListaComprasAPI.Domain.Aggregations.Base;

namespace ListaComprasAPI.Domain.Interfaces.Services
{
    public interface IServiceUpdate<T> where T : BaseModel
    {
        bool Update(T model);
    }
}
