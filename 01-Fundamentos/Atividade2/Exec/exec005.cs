
static class exec005
{
    public static void exercicio005()
    {
        int a = 1;
        int b = 12;
        int c = -13;

        double x1 = (-b + Math.Sqrt(((Math.Pow(b, 2) - 4 * a * c)))) / 2 * a;
        double x2 = (-b - Math.Sqrt(((Math.Pow(b, 2) - 4 * a * c)))) / 2 * a;

        Console.WriteLine(x1);
        Console.WriteLine(x2);
        Console.WriteLine("********************************************************************");
    }
}