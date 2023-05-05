/*8- Escreva um programa para calcular o fatorial de um número inteiro. 
O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1*/

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
