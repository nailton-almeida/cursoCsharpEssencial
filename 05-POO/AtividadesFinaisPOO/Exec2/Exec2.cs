using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesFinaisPOO
{
    static class Exec02
    {
        public static void Exec002()
        {
            LivroFotos livrofoto = new();
            LivroFotos livrofotocustom = new(24);
            SuperLivroFotos SuperLivroFotos = new();

        
            Console.WriteLine($"Número de paginas do livro 1 : {livrofoto.GetNumeroPaginas()}");
            Console.WriteLine($"Número de paginas do livro 1 : {livrofotocustom.GetNumeroPaginas()}");
            Console.WriteLine($"Número de paginas do livro 1 : {SuperLivroFotos.GetNumeroPaginas()}");

             
        }

    }

     
}
