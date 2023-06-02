namespace AtividadesFinais.Exec2
{
    static class Exec02
    {
        public static void Exec002()
        {
            Console.WriteLine("Digite a quantidade de valores do array");
            int qtdArray = int.Parse(Console.ReadLine());
            int[] arraynumeros = new int[qtdArray];

            PreencherArray(qtdArray, arraynumeros);
            BuscarValor(arraynumeros);

            static void PreencherArray(int qtdArray, int[] arraynumeros)
            {
                Random valoresArray = new Random();

                for (int i = 0; i < arraynumeros.Length; i++)
                {
                    arraynumeros[i] = valoresArray.Next(700);
                }

            }

            static void BuscarValor(int[] arraynumeros)
            {
                string valorBusca;

                do
                {
                    Console.WriteLine("Digite o valor desejado para a busca - Digite fim para encerrar a execução");
                    valorBusca = Console.ReadLine();

                    if (valorBusca == "fim")
                    {
                        Console.WriteLine("Saindo do sistema");
                        break;
                    }

                    else if (arraynumeros.Contains(Int32.Parse(valorBusca)))
                    {

                        Console.WriteLine($"O valor procurado se encontra no array");
                    }

                    else
                    {
                        Console.WriteLine("O valor esperado não se encontra no array");
                    }


                } while (true);

            }
        }
    }
}
