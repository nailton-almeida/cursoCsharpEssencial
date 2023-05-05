/*9- Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado*/

static class exec009
{
    public static void exercicio009()
    {
        int i = 2;
        int j = 1;

        do
        {
            Console.WriteLine($"**** TABUADA DO {i} ****");
            do
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
                j++;

            } while (j <= 10);

            i++;
            j = 1;
        } while (i <= 6);
    }
}

