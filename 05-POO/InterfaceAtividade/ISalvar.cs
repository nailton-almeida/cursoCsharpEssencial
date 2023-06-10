using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAtividade
{
    internal interface ISalvar
    {
        public abstract void Salvar();

        public void Compactar()
        {
            Console.WriteLine($"Método compactar implementado na interface");
        }

    }
}
