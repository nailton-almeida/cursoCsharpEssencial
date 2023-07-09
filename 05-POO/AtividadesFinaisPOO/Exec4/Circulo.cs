
namespace AtividadesFinaisPOO;

public class Circulo : Formas
{
    private double raio { get; set; }

    public Circulo(int raio)
    {
        this.raio = raio;
    }

    public override void CalcularArea()
    {
        var area = Math.PI * raio * raio;
        Console.WriteLine($"A area do círculo é {area}");
    }

   
}

