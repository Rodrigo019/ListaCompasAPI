using ListaComprasAPI.Domain.Aggregations.Base;

namespace ListaComprasAPI.Domain.Aggregations.Acao.Models
{
    public class AcaoModel : BaseModel
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
