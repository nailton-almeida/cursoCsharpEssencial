using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesFinaisPOO
{
    public class Quadrado : Formas
    {
        private double lado { get; set; }

        public Quadrado(double lado)
        {
            this.lado = lado;

        }
     

        public override void CalcularArea()
        {
            double area = lado * lado;
            Console.WriteLine($"A área do quadrado é {area}");
        }
    }
}
