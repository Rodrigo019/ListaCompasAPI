using System;

namespace ListaComprasAPI.Domain.Excpetions
{
    public class ExcecaoDeValidacao : Exception
    {
        public ExcecaoDeValidacao(string mensagem) : base(mensagem) { }
    }
}
