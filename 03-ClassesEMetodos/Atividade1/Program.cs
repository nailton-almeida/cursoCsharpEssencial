using Concessionaria.Dominio;
using static Concessionaria.Dominio.Carro;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine($"Escolha uma das cores abaixo pelo id:");
        Console.WriteLine($"{Cores.Branco} : {(int)Cores.Branco}");
        Console.WriteLine($"{Cores.Vermelho} : {(int)Cores.Vermelho}");
        Console.WriteLine($"{Cores.Preto} : {(int)Cores.Preto}");
        Console.WriteLine($"{Cores.Cinza} : {(int)Cores.Cinza}");
        Console.WriteLine($"{Cores.Prata} : {(int)Cores.Prata}");
        var cor = Convert.ToInt32(Console.ReadLine());

        int potencia = 10;
        double velocidade;

        Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);
        chevrolet.Ano = 1999;
        
        Carro ford = new("SUV", "Ford");

        chevrolet.Acelerar(chevrolet.Marca);
        Console.WriteLine($"{chevrolet.Modelo}, {chevrolet.Montadora}, {chevrolet.Marca}, {chevrolet.Ano}, {chevrolet.Potencia}\n");

        ford.Acelerar(ford.Marca);
        Console.WriteLine($"{ford.Modelo}, {ford.Montadora}\n");

        //Utilizando o conceito de argumento opcional
        ford.ExibirInfo("Ford Ka", "Ford", "SEL", 10);

        //Utilizando o conceito de argumento nomeado
        ford.ExibirInfo("Ford Ka", "Ford", "SEL", 10, ano: 1950);
        ford.ExibirInfo("Ford Ka", "Ford", "SEL", 10);

        //Passagem de parametro por valor
        var potenciaAumentada = chevrolet.AumentarPotencia(potencia);
        Console.WriteLine($"A potencia do veiculo é {potenciaAumentada}");

        //Passagem de valor por referencia. O out retorna o valor atribuido exclusivamente no método para a variável no escopo do main
        ford.AumentarPotenciaVelocidade(potencia, out velocidade);
        Console.WriteLine($"A potencia é {potencia} e a velocidade é {velocidade}");

        //Passagem de paramentro por referencia
        ford.AumentarPotencia(ref potencia);
        Console.WriteLine($"A potencia do veiculo é {potencia}");

    }
}

