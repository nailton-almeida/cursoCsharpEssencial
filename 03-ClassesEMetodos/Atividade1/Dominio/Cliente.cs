namespace Concessionaria.Dominio;



public struct Cliente
{
    public string? Nome;
    public string? Email;
    private int idade;

    public int Idade
    {
        get { return idade; }
        set
        {
            idade = value < 18 ? 18 : value;
        }

    }

    public Cliente(string Nome, string Email, int Idade)
    {
        this.Nome = Nome;
        this.Email = Email;
        this.Idade = Idade;
    }

    public static void ExibirInfo(string nome, string email, int idade = 10)
    {
        Console.WriteLine($"{nome}, {email}, {idade}");
    }

}
