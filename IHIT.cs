using System;
using System.Collections;
using System.Collections.Generic;

namespace Strategy.Pattern
{
    public class IHIT : TempleteDeImpostoCondicional
    {
        protected override double AplicaMaximaTaxacao(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        protected override double AplicaMinimaTaxacao(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        protected override bool DevoUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ExisteDoisItensComOMesmoNome(orcamento);
        }

        private bool ExisteDoisItensComOMesmoNome(Orcamento orcamento)
        {
            IList orcamentoAuxiliar = new List<string>();
            foreach (var item in orcamento.Itens)
            {
                if (orcamentoAuxiliar.Contains(item.Nome))
                    return true;

                orcamentoAuxiliar.Add(item.Nome);
            }
            return false;
        }
    }
}
