using System.Collections;
namespace AtividadesFinais.Desafios;

static class Exec04
{

    public static void Exec004()
    {
        Pessoa pessoa = new();

        var listaPessoa = pessoa.IncluirPessoas();
        pessoa.Exibir(listaPessoa);
    }



}

