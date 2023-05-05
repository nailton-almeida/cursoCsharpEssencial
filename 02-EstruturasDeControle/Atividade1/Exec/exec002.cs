//2-Escreva um programa para calcular a raiz da equação quadrática
static class exec002
{
    public static void exercicio002()
    {
        Console.WriteLine("Digite o valor A:");
        int valorA = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor B:");
        int valorb = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor C:");
        int valorC = int.Parse(Console.ReadLine());

        double delta = Math.Pow(valorb, 2) - 4 * valorA * valorC;

        if (delta > 0)
        {
            double x1 = (-valorb + Math.Sqrt(delta)) / 2 * valorA;
            double x2 = (-valorb - Math.Sqrt(delta)) / 2 * valorA;

            Console.WriteLine("As raízes são reais diferentes");
            Console.WriteLine($"Primeira raiz x1= {x1}");
            Console.WriteLine($"Segunda raiz x2= {x2}");

        }

        else if (delta == 0)
        {
            double x1 = (-valorb + Math.Sqrt(delta)) / 2 * valorA;
            double x2 = (-valorb - Math.Sqrt(delta)) / 2 * valorA;

            Console.WriteLine("As raízes são reais iguais");
            Console.WriteLine($"Primeira raiz x1= {x1}");
            Console.WriteLine($"Segunda raiz x2= {x2}");
        }

        else if (delta < 0)
            Console.WriteLine("A equação não tem raizes");


    }
}

