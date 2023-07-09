namespace AtividadesFinais.Desafios;

static class Exec03
{
    public static void Exec003()
    {
        static void CadastrarNotaAluno()
        {
            float[,] notas = new float[2, 3];

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.WriteLine($"Digite a nota do Aluno {i}");
                    notas[i, j] = float.Parse(Console.ReadLine());
                }
            }

            CalculaMediaNotas(notas);

        }


        static void CalculaMediaNotas(float[,] notas)
        {
            float mediaGrupo = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {

                    mediaGrupo += notas[i, j];

                }
                Console.WriteLine($"Média do grupo {i} é {mediaGrupo / notas.GetLength(1)}");
                mediaGrupo = 0;
            }
        }
    }
}
