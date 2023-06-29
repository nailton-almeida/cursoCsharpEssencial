using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesFinaisPOO
{
    public class Professor: Pessoa
    {
        public Professor(string nome):base(nome)
        {
            
        }

        public void Explicar()
        {
            Console.WriteLine($"PROFESSOR {_nome} ESTÁ ENSINANDO");
        }

    }
}
