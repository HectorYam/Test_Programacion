using System;
using System.Text;

class Program
{
    static void Main()
    {
                                        //Hector gabriel Yam Cetina
        //Ejercicio 3: Comprimir Cadena
        //Crea una función que tome una cadena de caracteres y devuelva una versión comprimida de la cadena.Por ejemplo, la cadena "aaabbbcc" se comprimiría como "a3b3c2".Si la cadena comprimida no sería más corta que la original, debería devolver la cadena original.




        //Variable para 
        string palabra = "naaasssaaa";
        string comprimida = ComprimirCadena(palabra);

        Console.WriteLine($"Palabra original: {palabra}");
        Console.WriteLine($"Palabra comprimida: {comprimida}");
    }

    static string ComprimirCadena(string cadena)
    {
        if (string.IsNullOrEmpty(cadena))
            return cadena;

        StringBuilder resultado = new StringBuilder();
        char caracterActual = cadena[0];
        int conteo = 1;

        for (int i = 1; i < cadena.Length; i++)
        {
            if (cadena[i] == caracterActual)
            {
                conteo++;
            }
            else
            {
                resultado.Append(caracterActual);
                resultado.Append(conteo);
                caracterActual = cadena[i];
                conteo = 1;
            }
        }

        resultado.Append(caracterActual);
        resultado.Append(conteo);

        // Devolver la cadena comprimida solo si es más corta que la original
        return resultado.Length < cadena.Length ? resultado.ToString() : cadena;
    }
}