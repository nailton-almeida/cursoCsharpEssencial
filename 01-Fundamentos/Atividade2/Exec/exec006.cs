
//6 - Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login inválido’: (use o operador condicional ternário) 

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