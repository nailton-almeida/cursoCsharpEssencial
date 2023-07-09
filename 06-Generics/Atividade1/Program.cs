

ClasseGenerica<int> classGeneric = new();

classGeneric.Adicionar(10);
classGeneric.Adicionar(105);
classGeneric.Adicionar(30);
classGeneric.Adicionar(410);
classGeneric.Adicionar(510);

classGeneric.Exibir();

public class ClasseGenerica<T>
{

    T[] obj = new T[5];
    int contador = 0;


    public T this[int i]
    {
        get { return obj[i]; }

        set { obj[i] = value; }

    }

    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;

    }

    public void Exibir()
    {
        for (int i = 0; i < obj.Length; i++) {

            Console.WriteLine($"Posição {i} contém o valor {obj[i]}");
        }
    }


   



    
}