
static class exec004
{
    public static void exercicio004()
    {
        int numero = 0;

        while (numero != 999)
        {
            Console.WriteLine("Informe o numero da tabuada (Para sair digite 999):");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Número válido!");
                Console.WriteLine($"A tabuada do número {numero} é:");
                for (int i = 1; i <= 10; i++)
                {

                    Console.WriteLine($"{i} x {numero} = {i * numero}");
                }
            }
            else
            {
                Console.WriteLine("Não é possível digital zero");
            }

        }
        Console.WriteLine("Obrigado por participar");
    }

}
