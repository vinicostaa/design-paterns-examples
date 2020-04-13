using System;
namespace Strategy.Pattern
{
    public abstract class TempleteDeImpostoCondicional : Imposto
    {
        public TempleteDeImpostoCondicional(Imposto outroImposto) : base(outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public TempleteDeImpostoCondicional() : base()
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            if(DevoUsarMaximaTaxacao(orcamento))
            {
                return AplicaMaximaTaxacao(orcamento);
            }
            return AplicaMinimaTaxacao(orcamento);
        }

        protected abstract bool DevoUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double AplicaMaximaTaxacao(Orcamento orcamento);
        protected abstract double AplicaMinimaTaxacao(Orcamento orcamento);
    }
}
