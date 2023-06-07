namespace Banco
{
    public class Contas
    {
        public string? nome;
        public int numero;
        public decimal saldo { get; set; } = 0.00m;
        public virtual decimal Juros { get; set; } = 0.00m;


        public Contas(string nomeCliente, int numeroConta, decimal depositoInicial)
        {
            numero = numeroConta;
            nome = nomeCliente;
            saldo = depositoInicial;
        }

        public decimal Depositar(decimal deposito)
        {
            saldo += deposito + ((saldo + deposito) * Juros);
            return saldo;

        }

        public virtual decimal Sacar(decimal saque)
        {
            saldo -= saque;
            return saldo;
        }

        internal void ExibirSaldo()
        {
            Console.WriteLine($"Saldo do cliente {nome} é de R$ {saldo} reais");
        }

    }
}