namespace AtividadesFinais.Desafios;

public class Produto
{
    public string? Nome;
    public decimal Preco;


    public static void Exibir(List<Produto> produtos)
    {
        decimal somaproduto = 0;


        Console.WriteLine($"A quantidade de produtos na lista é: {produtos.Count}\n");
        Console.WriteLine($"Os produtos da lista são:\n");
        foreach (var item in produtos)
        {
            Console.WriteLine($"- {item.Nome} - R${item.Preco}");
            somaproduto += item.Preco;
        }
        Console.WriteLine($"A soma dos preços do produto é {somaproduto} e a média dos preços é {somaproduto / produtos.Count}");
    }

    public static void InverteArray(List<Produto> produtos)
    {

        List<Produto> sortedList = produtos.OrderBy(x => x.Nome).ToList();
        foreach (var item in sortedList)
        {
            Console.WriteLine($"- {item.Nome} - R${item.Preco}");

        }

    }

    public static void MenorPreco(List<Produto> produtos, decimal valorbusca)
    {

        foreach (var item in produtos)
        {
            if (item.Preco <= valorbusca)
            {
                Console.WriteLine($"Produto {item.Nome} - Preço {item.Preco}");
            }
        }
    }

    public static void BuscarProduto(List<Produto> produtos, string busca)
    {
        var result = produtos.Find(t => t.Nome == busca);
        if (result != null)
        {
            Console.WriteLine($"O produto {busca} está na lista");
        }

        else
        {
            Console.WriteLine($"O produto {busca} NÃO está na lista");
        }
    }
}
