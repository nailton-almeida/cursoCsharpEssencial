static class exec001
{
    public static void exercicio001()

    {
        Console.WriteLine("Digite o primeiro número");
        int primeiroNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        int segundoNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número");
        int terceiroNumero = int.Parse(Console.ReadLine());

        int[] numeros = {primeiroNumero,segundoNumero,terceiroNumero};
        int maiorvalor=0;

        foreach (int valor in numeros)
        {               
            maiorvalor = maiorvalor < valor ? valor : maiorvalor;
        }
        Console.WriteLine($"Maior número é o {maiorvalor}");
    }
}


