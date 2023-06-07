// See https://aka.ms/new-console-template for more information
using Banco;


ContaCorrente NailtonCC = new ContaCorrente("Nailton", 1994, 1000);
ContaPoupanca MariaCP = new ContaPoupanca("Maria", 2000, 1000);
ContaInvestimento JoaoCI = new ContaInvestimento("Joao", 2010, 1000);

NailtonCC.Depositar(1000);
NailtonCC.ExibirSaldo();
