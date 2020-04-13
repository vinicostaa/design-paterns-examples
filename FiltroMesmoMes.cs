using System;
using System.Collections.Generic;

namespace Strategy.Pattern
{
    public class FiltroMesmoMes : Filtro
    {
        public FiltroMesmoMes() : base()
        {
        }

        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro)
        {

        }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtradas = new List<Conta>();

            foreach (Conta conta in contas)
            {
                if(conta.DataAbertura.Month == DateTime.Now.Month
                    && conta.DataAbertura.Month == DateTime.Now.Year)
                {
                    filtradas.Add(conta);
                }
            }

            foreach (Conta conta in Proximo(contas))
            {
                filtradas.Add(conta);
            }

            return filtradas;
        }
    }
}
