 

namespace AtividadesFinaisPOO;

public class Aluno:Pessoa
{

    public Aluno(string nome) : base(nome)
    {
        
    }

    public void Estudar()
    {
        Console.WriteLine($"ALUNO {_nome} ESTÁ ESTUDANDO");
    }


}
