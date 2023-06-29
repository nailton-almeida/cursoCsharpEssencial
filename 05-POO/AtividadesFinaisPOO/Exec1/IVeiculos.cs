using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesFinaisPOO
{

    public interface IVeiculos
    {
        public void Dirigir();

        public abstract bool Abastecer(int quantidadeAbastercer);


    }

}

