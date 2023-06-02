using System.Collections;

namespace AtividadesFinais.Exec4
{
    public class Pessoa
    {
        public string nome;
        public string idade;


        public ArrayList IncluirPessoas()
        {
            ArrayList dados = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine("Digite o nome da pessoa:");
                string nomeDigitado = Console.ReadLine();

                Console.WriteLine("Digite a idade da pessoa:");
                string idadeDigitada = Console.ReadLine();

                dados.Add(new Pessoa() { nome = nomeDigitado, idade = idadeDigitada });
               
            }
            return dados;
        }

        public void Exibir(ArrayList dadosPessoas)
        {
            foreach (Pessoa item in dadosPessoas)
            {
                Console.WriteLine($"Nome {item.nome} e idade {item.idade}");
            }
        }
    }
}
