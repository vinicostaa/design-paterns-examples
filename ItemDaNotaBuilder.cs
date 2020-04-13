using System;
namespace Strategy.Pattern
{
    public class ItemDaNotaBuilder
    {
        private string Nome { get; set; }
        private double Valor { get; set; }

        public ItemDaNotaBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }

        public ItemDaNota Builder()
        {
            return new ItemDaNota(Nome, Valor);
        }
    }
}
