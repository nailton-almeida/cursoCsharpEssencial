
//2 - Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

static class exec002
{
    public static void exercicio002()
    {
        string nomeAluno = "Paulo";
        int idadeAluno = 17;
        float notaAluno = 7.5f;

        Console.WriteLine($"Aluno {nomeAluno}\n tem {idadeAluno} anos e\n nota {notaAluno}");
        Console.WriteLine("********************************************************************");

    }
}