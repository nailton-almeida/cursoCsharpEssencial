namespace Banco
{
    public class ContaInvestimento : Contas
    {
        public ContaInvestimento(string nomeCliente, int numeroConta, decimal depositoInicial) : base(nomeCliente, numeroConta, depositoInicial)
        {
        }

        public override decimal Juros { get; set; } = 0.009m;
        public decimal Imposto { get; set; } = 0.001m;

        public override decimal Sacar(decimal saque)
        {

            if (saldo < saque)
            {
                Console.WriteLine($"Saldo insuficiente para saque");
                return saldo;
            }
            else
            {
                saldo += saque - ((saldo - saque) * Imposto);
                Console.WriteLine("Saque autorizado");
                return saldo;
            }
        }

         
    }
}

