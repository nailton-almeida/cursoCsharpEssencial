//3 - Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings

static class exec003
{
    public static void exercicio003()
    {
        Console.WriteLine("Digite a primeira letra");
        string letra1 = Console.ReadLine();

        Console.WriteLine("Digite a segunda letra");
        string letra2 = Console.ReadLine();

        Console.WriteLine("Digite a terceira letra");
        string letra3 = Console.ReadLine();

        Console.WriteLine("Com concatenação " + letra3 + letra2 + letra1);
        Console.WriteLine($"Com interpolação {letra3}{letra2}{letra1}");
        Console.WriteLine("********************************************************************");

    }
}