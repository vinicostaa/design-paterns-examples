using System;
namespace Strategy.Pattern
{
    public class DescontoPorCincoItems : TempleteDeDescontos
    {
        protected override double CalculaDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01;
        }

        protected override bool DevoAplicarDesconto(Orcamento orcamento)
        {
            return orcamento.Itens.Count > 5;
        }
    }
}
