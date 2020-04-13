namespace Strategy.Pattern
{
    public class DescontoPorVendaCasada : TempleteDeDescontos
    {
        public bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (ItemDaNota item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }

        protected override double CalculaDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override bool DevoAplicarDesconto(Orcamento orcamento)
        {
            return Existe("Lapis", orcamento) && Existe("Caneta", orcamento);
        }
    }
}