using System;
using System.Collections.Generic;

namespace Strategy.Pattern
{
    public class Orcamento
    {
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }
        public IList<ItemDaNota> Itens { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<ItemDaNota>();
            EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(ItemDaNota item)
        {
            Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
    }
}
