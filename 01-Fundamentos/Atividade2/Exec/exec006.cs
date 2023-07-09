
static class exec006
{
    public static void exercicio006()
    {
        Console.WriteLine("Digite ");
        string name = Console.ReadLine();
        string pass = Console.ReadLine();

        string resultado = (name == "admin" || name == "maria") && pass == "123" ? "Login feito com sucesso" : "Login inválido";
        Console.WriteLine(resultado);
        Console.WriteLine("********************************************************************");

    }
}