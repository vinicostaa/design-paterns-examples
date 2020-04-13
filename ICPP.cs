using System;
namespace Strategy.Pattern
{
    public class ICPP : TempleteDeImpostoCondicional
    {
        protected override double AplicaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double AplicaMinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override bool DevoUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500.0;
        }
    }
}
