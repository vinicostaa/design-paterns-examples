using System;
namespace Strategy.Pattern
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Salva do banco");
        }
    }
}
