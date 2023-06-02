string[] nomes = new string[5];
double[] notas = new double[5];
double mediaNota = 0;

for (int i = 0; i < nomes.Length; i++)

{
    Console.WriteLine("**********************************");
    Console.WriteLine("Digite o nome do aluno abaixo:");
    nomes[i] = Console.ReadLine();

    Console.WriteLine("**********************************");
    Console.WriteLine("Digite a nota do aluno abaixo:");
    notas[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < nomes.Length; i++)
{
    mediaNota += notas[i];
    Console.WriteLine($"O aluno {nomes[i]} ficou com a nota final {notas[i]}");
}
Console.WriteLine($"A média aritmética das notas dos alunos é {mediaNota / notas.Length}");
