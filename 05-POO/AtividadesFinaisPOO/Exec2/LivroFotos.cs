using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AtividadesFinaisPOO
{
    public class LivroFotos
    {
        private int numPaginas;
        public int _numPaginas {

            get { return numPaginas; }


            set { numPaginas = value; }
        }

        public int GetNumeroPaginas()
        {
            return _numPaginas;
        }

        public LivroFotos()
        {
            _numPaginas = 16;
        }

        public LivroFotos(int paginasDesejadas)
        {
            _numPaginas = paginasDesejadas;
        }

    
    }
}
