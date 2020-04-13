using System;
using System.Collections.Generic;

namespace Strategy.Pattern
{
    public abstract class Filtro
    {
        public Filtro OutroFiltro { get; set; }

        public Filtro()
        {
            OutroFiltro = null;
        }

        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if (OutroFiltro == null) return new List<Conta>();
            return OutroFiltro.Filtra(contas);
        }

    }
}
