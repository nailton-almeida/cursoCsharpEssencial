static class exec008
{
    public static void exercicio008()
    {
        Console.WriteLine("Digite o número que você quer o fatorial");
        int valor = int.Parse(Console.ReadLine());
         
        for (int i = valor; i > 1; )
        {
            valor *= --i;
        }
        Console.WriteLine($"O fatorial é {valor} ");
    }
}
