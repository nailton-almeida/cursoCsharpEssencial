string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine("*************************");
        Console.WriteLine($"Digite o nome do Aluno na posição [{i},{j}]");
        alunos[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("*************************");
for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {

        Console.WriteLine($"Aluno {alunos[i, j]} está na posição [{i},{j}]");
        Console.WriteLine();
    }
}

