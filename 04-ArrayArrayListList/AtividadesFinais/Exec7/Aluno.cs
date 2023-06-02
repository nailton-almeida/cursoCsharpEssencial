using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesFinais.Exec7
{
    public class Aluno
    {
        string[] alunos = new string[10];

        public string this[int i]
        {

            get
            {
                if (i >= 0 && i < alunos.Length)
                {
                    return alunos[i];
                }
                return "Erro";

            }
            set
            {
                if (i >= 0 && i <= alunos.Length)
                {
                    alunos[i] = value;
                } 
            }

        }
    }
}
