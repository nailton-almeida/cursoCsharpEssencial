//1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.

static class exec001
{
    public static void exercicio001()
    {
        string nome = "Paulo";
        int idade = 17;
        float nota = 7.5f;

        Console.WriteLine("Com interpolação:");
        Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

        Console.WriteLine("Com concatenação:");
        Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);

        Console.WriteLine("********************************************************************");

    }
}