
//7 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no console se x é par ou não e se y é par ou não.

static class exec007
{
    public static void exercicio007()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine(x % 2 == 0 ? "È par" : "É impar");
        Console.WriteLine(y % 2 == 0 ? "È par" : "É impar");
        Console.WriteLine("********************************************************************");

    }
}