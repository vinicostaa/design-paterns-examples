using System;
namespace Strategy.Pattern
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public bool DescontoJaAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if(DescontoJaAplicado)
            {
                orcamento.Valor -= (orcamento.Valor * 0.6);
                DescontoJaAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovacao nao pode ir para finalizado direto");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
