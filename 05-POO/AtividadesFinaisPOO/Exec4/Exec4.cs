using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesFinaisPOO
{
    public class Exec04
    {
        public static void Exec004()
        {
            Circulo circulo = new(5);
            circulo.CalcularArea();

            Quadrado quadrado = new(5);
            quadrado.CalcularArea();

            Triangulo triangulo = new(10, 15);
            triangulo.CalcularArea();

        }
    }
}
