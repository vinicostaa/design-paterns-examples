using System;
namespace Strategy.Pattern
{
    public class IKCV : TempleteDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }

        protected override double AplicaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double AplicaMinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        protected override bool DevoUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && ExisteItemComValorMaiorQue100(orcamento);
        }

        public bool ExisteItemComValorMaiorQue100(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100.0) return true;
            }

            return false;
        }
    }
}
