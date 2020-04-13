using System;

namespace Strategy.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Estrategy
            // ####### TIPOS DE IMPOSTOS
            //Orcamento orcamento = new Orcamento(500.0);
            //CalculadorDeImposto calculadorDeImposto = new CalculadorDeImposto();
            //double iss = calculadorDeImposto.RealizaCalculo(orcamento, new ISS());
            //double icms = calculadorDeImposto.RealizaCalculo(orcamento, new ICMS());
            //Console.WriteLine(iss);
            //Console.WriteLine(icms);
            //Console.ReadKey();

            // ###### TIPOS DE INVESTIDORES
            //Conta conta = new Conta(1000);
            //RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();
            //double resultadoConservador = realizador.RealizaInvestimento(conta, new Conservador());
            //conta.Deposita(resultadoConservador);
            //Console.WriteLine($"conservador: {conta.Saldo}");

            //conta = new Conta(1000);
            //Conta conta1 = new Conta(1000);

            //Moderado moderado = new Moderado();
            //double resultadoModerado = realizador.RealizaInvestimento(conta, moderado);
            //double resultadoModerado1 = realizador.RealizaInvestimento(conta1, moderado);

            //conta.Deposita(resultadoModerado);
            //conta1.Deposita(resultadoModerado1);

            //Console.WriteLine($"conta: {conta.Saldo}");
            //Console.WriteLine($"conta 1: {conta1.Saldo}");

            //conta = new Conta(1000);
            //double resultadoArojado = realizador.RealizaInvestimento(conta, new Arojado());
            //conta.Deposita(resultadoArojado);
            //Console.WriteLine($"arojado: {conta.Saldo}");
            //Console.ReadKey();
            #endregion

            #region Chain of Responsibility
            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(1000);
            //orcamento.AdicionaItem(new Item("Caneta", 500));


            //double desconto = calculador.Calcula(orcamento);
            //Console.WriteLine(desconto);

            //Console.ReadKey();
            #endregion

            #region Templete Method
            //Orcamento orcamento = new Orcamento(501.0);
            //orcamento.AdicionaItem(new Item("Caneta", 500));
            //orcamento.AdicionaItem(new Item("Lapis", 500));
            //CalculadorDeImposto calculadorDeImposto = new CalculadorDeImposto();
            //double icpp = calculadorDeImposto.RealizaCalculo(orcamento, new ICPP());
            //Console.WriteLine(icpp);
            //double ikcv = calculadorDeImposto.RealizaCalculo(orcamento, new IKCV());
            //Console.WriteLine(ikcv);
            #endregion

            #region Decorator
            //Imposto iss = new ISS(new ICMS(new IKCV(new ICCC())));
            //Imposto impostoMuitoAlto = new ImpostoMuitoAlto(new ICMS()); 
            //Orcamento orcamento = new Orcamento(500);
            //double valor = impostoMuitoAlto.Calcular(orcamento);

            //Console.WriteLine(valor);
            #endregion

            #region State
            //Orcamento reforma = new Orcamento(500);

            //reforma.AplicaDescontoExtra();
            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Aprova();

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);

            //reforma.Finaliza();
            #endregion

            #region State
            //Conta conta = new Conta();

            //conta.Saca(1000); 

            //Console.WriteLine(conta.Saldo);
            #endregion

            #region Criacao de objeto com Builder e Executandos varias ações com Observer - Builder e Observer
            NotaFiscalBuilder nfBuilder = new NotaFiscalBuilder()
                .ParaEmpresa("Caelum")
                .ComCnpj("123.456.789/0001-10")
                .ComItem(new ItemDaNotaBuilder()
                    .ComNome("Item 1")
                    .ComValor(100.0)
                    .Builder())
                .ComItem(new ItemDaNota("item 2", 200.0))
                .ComItem(new ItemDaNota("item 3", 300.0))
                .ComObservacoes("entregar nf pessoalmente");

            nfBuilder.AdicionaAcao(new EnviadorDeEmail());
            nfBuilder.AdicionaAcao(new EnviadorDeSms());
            nfBuilder.AdicionaAcao(new NotaFiscalDao());

            NotaFiscal nf = nfBuilder.Builder();
            #endregion
        }
    }
}
