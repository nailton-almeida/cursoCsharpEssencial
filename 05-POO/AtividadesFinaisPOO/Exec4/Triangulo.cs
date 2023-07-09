
namespace AtividadesFinaisPOO;

public class Triangulo : Formas
{
    private double basetriangulo { get; set; }
    private double altura { get; set; } 

    public Triangulo(double basetriangulo, double altura)
    {
        this.basetriangulo = basetriangulo;
        this.altura = altura;
    }

    public override void CalcularArea()
    {
        double area = ((basetriangulo * altura) / 2);
        Console.WriteLine($"A área do triangulo é {area}");
    }
}
