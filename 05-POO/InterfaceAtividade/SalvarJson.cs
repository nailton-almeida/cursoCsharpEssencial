﻿ 

namespace InterfaceAtividade;

internal class SalvarJson : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine($"Implementando o método Salvar() da Classe Abstrata ArquivoBase pelo classe derivada SalvarJson");
    }

    public override void Nome()
    {
        Console.WriteLine("Override no SalvarJson da classe base ArquivoBase");
    }
}
