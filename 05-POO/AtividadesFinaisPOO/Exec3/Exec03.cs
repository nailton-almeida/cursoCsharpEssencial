 

namespace AtividadesFinaisPOO;

static class Exec03
{
    public static void Exec003()
    {
        Pessoa[,] matrizPessoas = new Pessoa[3, 1];  //Criando matriz do tipo pessoa
       

        //Populando a matriz e criando os objetos do tipo aluno ou professor
        for (int i = 0; i < matrizPessoas.GetLength(0); i++)
        {
            for (int j = 0; j < matrizPessoas.GetLength(1); j++)
            {
                Console.WriteLine("Digite o nome da pessoa");
                string? nome= Console.ReadLine();

                Console.WriteLine("Escolha 1 para aluno ou 2 para professor");
                int perfil = int.Parse(Console.ReadLine());

                Pessoa pessoa;
                if (perfil == 1)
                {
                    pessoa = new Aluno(nome);
                }

                else
                    pessoa = new Professor(nome);

                matrizPessoas[i, j] = pessoa;
            }
        }

        //Chamando os métodos de acordo ao tipo de pessoa recebida da matriz.
        for (int i = 0; i < matrizPessoas.GetLength(0); i++)
        {
                            
            for (int j = 0; j < matrizPessoas.GetLength(1); j++)
            {
                Pessoa pessoa = matrizPessoas[i, j];
                if (pessoa is Aluno aluno)
                {
                    aluno.Estudar();
                }
                else if (pessoa is Professor professor)
                {
                    professor.Explicar();
                }
            }
        }

    }
}
