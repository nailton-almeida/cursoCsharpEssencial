//3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do-while e for.
static class exec003
{
    public static void exercicio003()
    {

        int somaWhile = 0;
        int iWhile = 1;

        int somaDoWhile = 0;
        int iDoWhile = 1;

        int somaForWhile = 0;
       

        while (iWhile <= 10)
        {

            somaWhile += iWhile;
            iWhile++;
        }
        Console.WriteLine($"Soma dos dez primeiros números naturais com loop While é {somaWhile}\n");

        do
        {
            somaDoWhile += iDoWhile;
            iDoWhile++;

        } while (iDoWhile <= 10);
        Console.WriteLine($"Soma dos dez primeiros números naturais com loop Do While é {somaDoWhile}\n");


        for (int iForWhile = 0; iForWhile <= 10; iForWhile++)
        {
            somaForWhile += iForWhile;
        }
        Console.WriteLine($"Soma dos dez primeiros números naturais com loop For é {somaForWhile}\n");
    }     

}

