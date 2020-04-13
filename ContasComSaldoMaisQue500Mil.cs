using System;
using System.Collections.Generic;

namespace Strategy.Pattern
{
    public class ContasComSaldoMaisQue500Mil : Filtro
    {
        public ContasComSaldoMaisQue500Mil() : base() {}
        public ContasComSaldoMaisQue500Mil(Filtro outroFiltro) : base(outroFiltro) {}

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtradas = new List<Conta>();
            
            foreach (var conta in contas)
            {
                if (conta.Saldo > 500.000) filtradas.Add(conta);
            }

            foreach (var conta in Proximo(contas))
            {
                filtradas.Add(conta);
            }

            return filtradas;
        }
    }
}
