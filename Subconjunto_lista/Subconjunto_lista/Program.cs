using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
                                                    //Hector Gabriel Yam Cetina
        //Ejercicio 1: Subconjuntos de una Lista
        //Escribe una función que tome una lista como entrada y devuelva todos los subconjuntos posibles de esa lista, incluido el conjunto vacío.

        //Crear una lista de tipo string
        List<string> lista = new List<string> { "e", "f", "g" };
        //Esta lista recibe como entrada una lista 
        List<List<string>> subconjunto = ObtenerSubconjuntos(lista);

        // Mostrar los datos en consola 
        Console.WriteLine("Subconjuntos:");
        foreach (var subset in subconjunto)
        {
            Console.WriteLine($"[{string.Join(", ", subset)}]");
        }
    }
    //Se obtiene los subconjuntos
    static List<List<T>> ObtenerSubconjuntos<T>(List<T> lista)
    {
        List<List<T>> subconjuntos = new List<List<T>>();
        int n = lista.Count;

        // En este ciclo se genera los numeros. 
        for (int i = 0; i < (1 << n); i++)
        {
            List<T> subset = new List<T>();

            // Construir el subconjunto actual usando bits
            for (int j = 0; j < n; j++)
            {
                if ((i & (1 << j)) > 0)
                {
                    subset.Add(lista[j]);
                }
            }

            // Sirve para agregar los subconjuntos
            subconjuntos.Add(subset);
        }

        //Retorna el subconjunto 

        return subconjuntos;
    }
}