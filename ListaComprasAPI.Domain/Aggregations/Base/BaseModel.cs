using System;

namespace ListaComprasAPI.Domain.Aggregations.Base
{
    public abstract class BaseModel
    {
        public long Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public abstract bool Validar();
    }
}
