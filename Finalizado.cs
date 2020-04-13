using System;
namespace Strategy.Pattern
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados nao recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O Orcamento está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("O Orcamento está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O Orcamento está finalizado");
        }
    }
}
