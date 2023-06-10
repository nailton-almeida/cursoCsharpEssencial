using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAtividade
{
    internal class SalvarXML : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine($"Implementando o método Salvar() da Classe Abstrata ArquivoBase pelo classe derivada SalvarXML");
        }

        public override void Nome()
        {
            Console.WriteLine("Override no SalvarJson da classe base ArquivoBase");
        }
    }
}
