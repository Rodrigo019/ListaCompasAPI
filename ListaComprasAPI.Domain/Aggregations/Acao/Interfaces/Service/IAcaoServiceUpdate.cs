using ListaComprasAPI.Domain.Aggregations.Acao.Models;
using ListaComprasAPI.Domain.Interfaces.Respositories;

namespace ListaComprasAPI.Domain.Aggregations.Acao.Interfaces.Service
{
    public interface IAcaoServiceUpdate :
        IRepositoryUpdate<AcaoModel>
    {
    }
}
