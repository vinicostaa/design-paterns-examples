using System;
namespace Strategy.Pattern
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base() { }
        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + CalculoDoOutroImposto(orcamento);
        }
    }
}
