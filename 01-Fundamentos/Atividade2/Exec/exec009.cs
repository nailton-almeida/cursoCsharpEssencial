
static class exec009
{
    public static void exercicio009()
    {

        Console.WriteLine("Digite a temperatura em Celsius para conversão");
        double temperaturaCelsius = double.Parse(Console.ReadLine());

        double temperaturaKelvin = temperaturaCelsius + 273;
        double temperaturaFarhenheit = (temperaturaCelsius * 1.8) + 32;

        Console.WriteLine($"A conversão para Kelvin é {temperaturaKelvin} graus");
        Console.WriteLine($"A conversão para Farhenheit é {temperaturaFarhenheit} graus");

        Console.WriteLine("********************************************************************");

    }
}