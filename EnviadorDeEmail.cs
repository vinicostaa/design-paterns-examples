using System;
namespace Strategy.Pattern
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("envia email");
        }
    }
}
