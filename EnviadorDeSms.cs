using System;
namespace Strategy.Pattern
{
    public class EnviadorDeSms : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("envia sms");
        }
    }
}
