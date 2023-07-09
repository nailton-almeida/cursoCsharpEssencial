static class exec004
{
    public static void exercicio004()
    {
        Console.WriteLine("Digite o primeiro valor:");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nSoma dos valores:" + (valor1 + valor2));
        Console.WriteLine("Subtração dos valores:" + (valor1 - valor2));
        Console.WriteLine("Multiplicação dos valores:" + (valor1 * valor2));
        Console.WriteLine("Divisão dos valores:" + (valor1 / valor2));
        Console.WriteLine("Módulo dos valores:" + (valor1 % valor2));
        Console.WriteLine("Potenciação dos valores:" + Math.Pow(valor1, valor2));
        Console.WriteLine("********************************************************************");

    }
}