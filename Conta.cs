using System;

namespace Strategy.Pattern
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public IEstadoDaConta Estado;
        public DateTime DataAbertura { get; set; }

        public Conta()
        {
            Estado = new ContaZerada();
        }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }

        public class ContaPositiva : IEstadoDaConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.98;
            }

            public void Saca(Conta conta, double valor)
            {
                conta.Saldo -= valor;

                if (conta.Saldo < 0)
                    conta.Estado = new ContaNegativa();
            }
        }

        public class ContaNegativa : IEstadoDaConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.95;
            }

            public void Saca(Conta conta, double valor)
            {
                throw new Exception("Conta com saldo negativo não permite saque");
            }
        }

        public class ContaZerada : IEstadoDaConta
        {
            public void Deposita(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.98;
            }

            public void Saca(Conta conta, double valor)
            {
                throw new Exception("Conta com saldo zerado não permite saque");
            }
        }
    }
} 