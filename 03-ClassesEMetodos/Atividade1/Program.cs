class Program
{
    static void Main(string[] args)
    {
        int potencia = 10;
        double velocidade;

        Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
        Carro ford = new("SUV", "Ford");

        chevrolet.Acelerar(chevrolet.Marca);
        System.Console.WriteLine($"{chevrolet.Modelo}, {chevrolet.Montadora}, {chevrolet.Marca}, {chevrolet.Ano}, {chevrolet.Potencia}\n");

        ford.Acelerar(ford.Marca);
        System.Console.WriteLine($"{ford.Modelo}, {ford.Montadora}\n");


        //Passagem de parametro por valor
        var potenciaAumentada = chevrolet.AumentarPotencia(potencia);
        System.Console.WriteLine($"A potencia do veiculo é {potenciaAumentada}");

        ford.AumentarPotenciaVelocidade(potencia, out velocidade);
        System.Console.WriteLine($"A potencia é {potencia} e a velocidade é {velocidade}");

        //Passagem de paramentro por referencia
        ford.AumentarPotencia(ref potencia);
        System.Console.WriteLine($"A potencia do veiculo é {potencia}");

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

    public Carro(string modeloCarro, string montadoraCarro)
    {
        Modelo = modeloCarro;
        Montadora = montadoraCarro;
    }

    public void Acelerar(string marca)
    {
        System.Console.WriteLine($"Acelerando meu carro {marca}");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        return potencia += 3;
    }

    public int AumentarPotencia(ref int potencia)
    {
        return potencia += 5;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
        
    }
}

