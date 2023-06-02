using System.Collections;

namespace AtividadesFinais.Exec4
{
    static class Exec04
    {

        public static void Exec004()
        {
            Pessoa pessoa = new();

            var listaPessoa = pessoa.IncluirPessoas();
            pessoa.Exibir(listaPessoa);
        }



    }
}

