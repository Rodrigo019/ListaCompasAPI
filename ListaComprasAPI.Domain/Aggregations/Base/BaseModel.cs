using System;

namespace ListaComprasAPI.Domain.Aggregations.Base
{
    public class BaseModel
    {
        public long Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
