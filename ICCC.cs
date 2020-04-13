using System;
namespace Strategy.Pattern
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto) { }
        public ICCC() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            if(orcamento.Valor < 1000)
            {
                return orcamento.Valor * 0.05;
            }
            else if(orcamento.Valor <= 3000)
            {
                return orcamento.Valor * 0.07;
            } else
            {
                return orcamento.Valor * 0.08 + 30.0;
            }
        }
    }
}
