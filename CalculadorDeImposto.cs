using System;
namespace Strategy.Pattern
{
    public class CalculadorDeImposto
    {
        public double RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
