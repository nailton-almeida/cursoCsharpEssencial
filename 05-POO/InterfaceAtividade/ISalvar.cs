 

namespace InterfaceAtividade;

internal interface ISalvar
{
    public abstract void Salvar();

    public void Compactar()
    {
        Console.WriteLine($"Método compactar implementado na interface");
    }

}
