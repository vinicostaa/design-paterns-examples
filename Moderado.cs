using System;
namespace Strategy.Pattern
{
    public class Moderado : IInvestimento
    {
        private Random random;

        public Moderado()
        {
            this.random = new Random();
        }

        public double CalculaRendimento(Conta conta)
        {
            if (random.Next(2) == 0)
                return conta.Saldo * 0.025;
            else
                return conta.Saldo * 0.007;
        }
    }
}
