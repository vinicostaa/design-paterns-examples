using System;
namespace Strategy.Pattern
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public bool DescontoJaAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if(!DescontoJaAplicado)
            {
                orcamento.Valor -= (orcamento.Valor * 0.5);
                DescontoJaAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está em estado de aprovação");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está em aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
