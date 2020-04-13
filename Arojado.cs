using System;
namespace Strategy.Pattern
{
    public class Arojado : IInvestimento
    {
        private Random random;
        public Arojado()
        {
            random = new Random();
        }

        public double CalculaRendimento(Conta conta)
        {
            int chute = random.Next(100);

            if (chute < 20) // 20% 
                return conta.Saldo * 0.5;
            else if (chute >= 20 && chute < 50) // 30%
                return conta.Saldo * 0.3;
            else
                return conta.Saldo * 0.06; // 50%

        }
    }
}
