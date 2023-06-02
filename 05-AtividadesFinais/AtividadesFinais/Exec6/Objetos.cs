using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesFinais.Exec6
{
    internal class Objetos
    {
        public static void ProcessaObjetos(params object[] listaObjetos)
        {
            Console.WriteLine("Os tipos dos objetos são:");
            
            foreach (object obj in listaObjetos)
            {
                Console.WriteLine($"Item : {obj} - Tipo: {obj?.GetType()}");
                
            }
        }
    }
}
