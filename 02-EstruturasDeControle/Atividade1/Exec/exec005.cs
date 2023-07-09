
static class exec005
{
    public static void exercicio005()
    {
        while (true)

        {
            Console.WriteLine("Tecle x para sair");
            Console.WriteLine("Qual a instrução para sair de um loop ?");
            Console.WriteLine("a.quit\nb.continue\nc.break\nd.exit");
            Console.WriteLine("Digite a alternativa correta");
            string escolha = Console.ReadLine();

            if (escolha == "c")
            {

                Console.WriteLine("ACERTOU");
                Console.WriteLine("##########");
            }

            else if (escolha == "x")
            {
                Console.WriteLine("Saindo do programa");
                break;
            }
            else
                Console.WriteLine("Tente novamente");
                Console.WriteLine("##########");


        }
    }
}
