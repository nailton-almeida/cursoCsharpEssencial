internal class Program
{
    private static void Main(string[] args)
    {
        List<Aluno> alunos = new()
    {
        new Aluno{Nome="Maria", Nota=8.75 },
        new Aluno{Nome="Amanda", Nota=7.25 },
        new Aluno{Nome="Carlos", Nota= 6.55 },
        new Aluno{Nome="Debora", Nota=5.95 },
        new Aluno{Nome="Alicia", Nota=9.25 },
        new Aluno{Nome="Sandra", Nota=5.55 },
        new Aluno{Nome="Marta", Nota=7.85 },
        new Aluno{Nome="Sueli", Nota=9.15 },
        new Aluno{Nome="Bia", Nota=7.75 },
        new Aluno{Nome="Mario", Nota=8.95 },


    };
    }
}

public class Aluno
{
    public string? Nome;
    public double Nota;

    public static void ExibirInfos(List<Aluno> alunos)
    {
        double somaNotas = 0;
        foreach (var aluno in alunos)
        {
            somaNotas = (somaNotas + aluno.Nota);
            Console.WriteLine($"O aluno(a) {aluno.Nome} obteve a nota {aluno.Nota}");
        }

        Console.WriteLine("************************************");
        Console.WriteLine($"A quantidade de alunos na lista é {alunos.Count}");
        Console.WriteLine($"A média aritmética das notas é {somaNotas / alunos.Count}");
    }
    public static void OrdenarAluno(List<Aluno> aluno)
    {

        foreach (var item in aluno.OrderBy(x => x.Nome))
        {
            Console.WriteLine($"O aluno(a) {item.Nome} obteve a nota {item.Nota}");
        }


    }

    public static void MaioresNotasAlunos(List<Aluno> aluno)
    {
        Console.WriteLine("Maiores notas dos alunos:");
        foreach (var item in aluno)
        {
            if (item.Nota >= 8)

                Console.WriteLine($"O aluno(a) {item.Nome} obteve a nota {item.Nota}");


        }
    }

    public static void RemoveAluno(List<Aluno> alunos, string alunoRemovido)
    {
        var busca = alunos.FindIndex(f => f.Nome == alunoRemovido);
        alunos.RemoveAt(busca);

    }

}