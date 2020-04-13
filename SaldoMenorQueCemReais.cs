using System;
using System.Collections.Generic;

namespace Strategy.Pattern
{
    public class SaldoMenorQueCemReais : Filtro
    {
        public SaldoMenorQueCemReais() : base() { }

        public SaldoMenorQueCemReais(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> contasFiltradas = new List<Conta>();

            foreach (var conta in contas)
            {
                if (conta.Saldo > 100) contasFiltradas.Add(conta);
            }

            foreach (var conta in Proximo(contas))
            {
                contasFiltradas.Add(conta);
            }

            return contasFiltradas;
        }
    }
}
