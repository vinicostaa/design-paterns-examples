using System;
namespace Strategy.Pattern
{
    public class RealizadorDeInvestimentos
    {
        public double RealizaInvestimento(Conta conta, IInvestimento investimento)
        {
            return investimento.CalculaRendimento(conta);
        }
    }
}
