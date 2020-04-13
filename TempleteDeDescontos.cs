using System;
namespace Strategy.Pattern
{
    public abstract class TempleteDeDescontos : IDesconto
    {
        public IDesconto Proximo { get; set; }
        protected abstract double CalculaDesconto(Orcamento orcamento);
        protected abstract bool DevoAplicarDesconto(Orcamento orcamento);

        public double Desconta(Orcamento orcamento)
        {
            if (DevoAplicarDesconto(orcamento))
                return CalculaDesconto(orcamento);

            return Proximo.Desconta(orcamento);
        }
    }
}
