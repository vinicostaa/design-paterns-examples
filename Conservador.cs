using System;
namespace Strategy.Pattern
{
    public class Conservador : IInvestimento
    {
        public double CalculaRendimento(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
