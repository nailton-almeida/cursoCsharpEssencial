
namespace AtividadesFinais.Exec
{
    static class Exec01
    {
        public static void Exec001()
        {
            string[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pera", "Abacate", "Mamão", "Pessego", "Amora" };

            static void ExibirArray(string[] frutas, string estruturaRepeticao)
            {
                Console.WriteLine($"A quantidade de itens no array é {frutas.Length}");
                if (estruturaRepeticao == "for")
                {
                    Console.WriteLine("Listagem de array com FOR:");
                    for (int i = 0; i < frutas.Length; i++)
                    {

                        Console.Write($"{frutas[i]} ");
                    }
                }

                else if (estruturaRepeticao == "foreach")
                {
                    Console.WriteLine("Listagem com FOREACH:");
                    foreach (var item in frutas)
                    {

                        Console.Write($"{item} ");
                    }

                }
            }

            static void ExibirValorPosicao(string[] frutas, int valorPosicao)
            {
                Console.WriteLine($"A fruta da posição {valorPosicao} é {frutas[valorPosicao]}");
            }

            static void EditarValorPosicao(string[] frutas, int valorPosicao, string novafruta)
            {
                frutas[valorPosicao] = novafruta;
                ExibirArray(frutas, "foreach");
            }

            static void OrdenaInverteArray(string[] frutas)
            {

                Array.Sort(frutas);
                Array.Reverse(frutas);
                ExibirArray(frutas, "foreach");

            }


        }




    }
}
