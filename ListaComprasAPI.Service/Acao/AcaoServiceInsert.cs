using ListaComprasAPI.Domain.Aggregations.Acao.Interfaces.Repository;
using ListaComprasAPI.Domain.Aggregations.Acao.Interfaces.Service;
using ListaComprasAPI.Domain.Aggregations.Acao.Models;

namespace ListaComprasAPI.Service.Acao
{
    public class AcaoServiceInsert : IAcaoServiceInsert
    {
        private readonly IAcaoRepositoryInsert _acaoRepositoryInsert;
        public AcaoServiceInsert(IAcaoRepositoryInsert acaoRepositoryInsert)
        {
            _acaoRepositoryInsert = acaoRepositoryInsert;
        }
        public bool Insert(AcaoModel model)
        {
            model.Validar();
            return _acaoRepositoryInsert.Insert(model);       
        }
    }
}
