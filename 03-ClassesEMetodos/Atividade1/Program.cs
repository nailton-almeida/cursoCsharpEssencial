class Program
{
    static void Main(string[] args)
    {

        Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
        Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

        chevrolet.Acelerar(chevrolet.Marca);
        System.Console.WriteLine($"{chevrolet.Modelo}, {chevrolet.Montadora}, {chevrolet.Marca}, {chevrolet.Ano}, {chevrolet.Potencia}\n");

        ford.Acelerar(ford.Marca);
        System.Console.WriteLine($"{ford.Modelo}, {ford.Montadora}, {ford.Marca}, {ford.Ano}, {chevrolet.Potencia}\n");
    }

}
public class Carro
{

    public string Modelo;
    public string Montadora;
    public string Marca;
    public int Ano;
    public int Potencia;

    public Carro(string Modelo, string Montadora, string Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public void Acelerar(string marca)
    {
        System.Console.WriteLine($"Acelerando meu {marca}");
    }
}

