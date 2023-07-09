
static class exec008
{
    public static void exercicio008()
    {
        const double PI = 3.1415d;

        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Os resultados são:");
        Console.WriteLine(-6 + (y * 5));
        Console.WriteLine((13 - 2) * y);
        Console.WriteLine((y + -2) * (20 / y));
        Console.WriteLine((12 + y) / (y - 4));
        Console.WriteLine(3 * Math.Pow(y, 2) + y + 10);
        Console.WriteLine(PI * (Math.Pow(y, 2)));

        Console.WriteLine("********************************************************************");

    }
}