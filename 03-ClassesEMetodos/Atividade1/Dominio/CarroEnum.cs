using System.Runtime.CompilerServices;

namespace Concessionaria.Dominio
{
    public class Carro
    {

        public string Modelo;
        public string Montadora;
        public string Marca;
        public int Potencia;
        public int Cor;
        public static double ValorIPVA;
        private int ano;
        public int Ano
        {
            get { return ano; }
            set
            {
                if (value < 2000)
                    ano = 2000;

                else if (value > 2022)
                    ano = 2022;

                else
                    ano = value;

            }
        }

        public enum Cores
        {
            Branco = 1,
            Vermelho,
            Preto,
            Cinza,
            Prata,
            Azul
        }

        public Carro(string Modelo, string Montadora, string Marca, int Ano, int Potencia, int Cor)
        {
             
            this.Modelo = Modelo;
            this.Montadora = Montadora;
            this.Marca = Marca;
            this.Ano = Ano;
            this.Potencia = Potencia;
            this.Cor = Cor;
        }

        public Carro(string modeloCarro, string montadoraCarro)
        {
            Modelo = modeloCarro;
            Montadora = montadoraCarro;
        }

 
        public void Acelerar(string marca)
        {
            Console.WriteLine($"Acelerando meu carro {marca}");
        }

        public double VelocidadeMaxima(int potencia)
        {
            return potencia * 1.75;
        }

        public int AumentarPotencia(int potencia)
        {
            return potencia += 3;
        }

        public int AumentarPotencia(ref int potencia)
        {
            return potencia += 5;
        }

        public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
        {
            potencia += 7;
            velocidade = potencia * 1.75;


            return potencia;

        }

        public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2023, int cor = 1)
        {
            Console.WriteLine($"Infos do carro - Modelo:{modelo} / Montadora:{montadora} / Marca:{marca} / Potencia:{potencia} / Ano:{ano} / Cor:{(Cores)cor}" );
        }

        public static void ObterValorIPVA()
        {
            ValorIPVA = 4;
        }
    }

}
