using System;
namespace Strategy.Pattern
{
    public class DescontoPorMaisDeQuinhentosReais : TempleteDeDescontos
    {
        protected override double CalculaDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override bool DevoAplicarDesconto(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }
    }
}
