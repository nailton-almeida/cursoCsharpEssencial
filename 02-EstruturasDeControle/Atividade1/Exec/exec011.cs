/*11 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
quando isso ocorrer exibir uma mensagem de alerta)*/


static class exec011
{
    public static void exercicio011()
    {
        Console.WriteLine("**** Calculadora ****");

        Console.WriteLine("Digite o valor 1:");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a operação:");
        string operacao = Console.ReadLine();

        Console.WriteLine("Digite o valor 2:");
        int valor2 = int.Parse(Console.ReadLine());

        switch (operacao)
        {
            case "+":
                Console.WriteLine($"A adição dos valores é {valor1 + valor2}");
                break;

            case "-":
                Console.WriteLine($"A subtração dos valores é {valor1 - valor2}");
                break;

            case "*":
                Console.WriteLine($"A multiplicação dos valores é {valor1 * valor2}");
                break;

            case "/":
                if (valor2 != 0)
                {
                    Console.WriteLine($"A divisão dos valores é {valor1 / valor2}");
                }

                else
                    Console.WriteLine("Não existe divisão por zero");
                break;

            default:
                Console.WriteLine("Reveja operação");
                break;
        }
    }
}
