using ListaComprasAPI.Domain.Aggregations.Base;
using ListaComprasAPI.Domain.Excpetions;

namespace ListaComprasAPI.Domain.Aggregations.Acao.Models
{
    public class AcaoModel : BaseModel
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new ExcecaoDeValidacao("O Nome da Ação não pode ser nulo ou vazio!");

            return true;
        }
    }
}
