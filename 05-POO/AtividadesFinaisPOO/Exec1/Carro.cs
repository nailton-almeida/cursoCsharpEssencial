 
namespace AtividadesFinaisPOO;

public class Carro : IVeiculos
{
    int quantidadeGasolina { get; set; } = 10;
    public Carro(int qtdGasolina)

    {

        quantidadeGasolina = qtdGasolina;


    }

    public bool Abastecer(int quantidadeAbastercer)
    {
        Console.WriteLine($"Abastecendo o carro em {quantidadeAbastercer} litros");
        return true;
    }

    public void Dirigir()
    {

        if (quantidadeGasolina <= 0)
        {
            Console.WriteLine("Sem gasolina, digite a quantidade a abastecer");
            int quantidadeAbastercer = int.Parse(Console.ReadLine());
            Abastecer(quantidadeAbastercer);
        }
        else


            Console.WriteLine("Dirigindo o carro...");
    }
}
