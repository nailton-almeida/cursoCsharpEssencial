namespace Banco;


public class ContaPoupanca : Contas
{
    public ContaPoupanca(string nomeCliente, int numeroConta, decimal depositoInicial) : base(nomeCliente, numeroConta, depositoInicial)
    {
    }

    public override decimal Juros { get; set; } = 0.005m;


    public override decimal Sacar(decimal saque)
    {
        if (saldo < saque)
        {
            Console.WriteLine($"Saldo insuficiente para saque");
            return saldo;
        }
        else
        {
            saldo += saque - ((saldo - saque));
            Console.WriteLine("Saque autorizado");
            return saldo;
        }



    }
}
