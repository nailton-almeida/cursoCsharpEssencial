namespace AtividadesFinais.Desafios;

public class Aluno
{
    string[] alunos = new string[10];

    public string this[int i]
    {

        get
        {
            if (i >= 0 && i < alunos.Length)
            {
                return alunos[i];
            }
            return "Erro";

        }
        set
        {
            if (i >= 0 && i <= alunos.Length)
            {
                alunos[i] = value;
            }
        }

    }
}
