/*10- Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
instrução switch, break e default em um loop infinito e defina uma condição de saida.)*/

static class exec010
{
    public static void exercicio010()
    {
        
        string entrada;

        do
        {
            Console.WriteLine("\nDigite a nota do aluno (para sair 5000):");
            entrada = Console.ReadLine();

            switch (entrada)
            {
                case "10":
                    Console.WriteLine("Avaliação A+");
                    break;
                case "9":
                    Console.WriteLine("Avaliação A");
                    break;
                case "7":
                case "8":
                    Console.WriteLine("Avaliação B");
                    break;
                case "6":
                    Console.WriteLine("Avaliação C");
                    break;
                case "5":
                    Console.WriteLine("Avaliação E");
                    break;
                case "4":
                case "3":
                case "2":
                case "1":
                case "0":
                    Console.WriteLine("Avaliação F");
                    break;

                default:
                    Console.WriteLine("Nota fora da tabela de avaliação");
                    break;
            }
            

        } while (entrada != "5000") ;
        Console.WriteLine("Saindo do programa");

    }
}

