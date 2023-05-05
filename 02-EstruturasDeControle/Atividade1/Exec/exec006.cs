/*6- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
maneiras diferentes
- Incrementando 2 em cada passo
- Incrementando 1 em cada passo 
- Com e loop infinito (use "break" e "continue")*/

//Observação de desenvolvimento: Nesse exercícios preferi adicionar todos os critérios de construção no mesmo método para polpar tempo

static class exec006
{
    public static void exercicio006()
    {
        for (int i = 10; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                if (i != 16)
                    Console.WriteLine($"Numero par {i}");
            }

            else
                continue;
            
            
        }
            
    }
}
