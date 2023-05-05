/*4- Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado 
-Verifique se o número é maior que zero e emita uma mensagem
- Considere a tabela de multiplicação de 1 até 10
- Após exibir a tabela torne a solicitar outro número 
- Para sair do loop defina uma condição de saída*/

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
