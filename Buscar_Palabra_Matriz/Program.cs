using System;

class Program
{
    static void Main()
    {
                                            //Hector Gabriel Yam Cetina 
        //Ejercicio 2: Buscar Palabra en Matriz
       // Dada una matriz de letras y una palabra, escribe un programa que determine si la palabra se puede encontrar en la matriz.La palabra puede estar en cualquier dirección(horizontal, vertical, diagonal).


        // Definir la matriz de letras y una palabra
        char[,] matriz = {
            {'g', 'a', 'z', 'g', 'e'},
            {'h', 'v', 'f', 'y', 'j'},
            {'j', 'n', 'a', 's', 'a'},
            {'t', 'h', 'r', 'k', 'k'},
            {'o', 'v', 'c', 'h', 'm'}
        };

        
        string palabra = "nasa";

        // Llamar a la función para buscar la palabra "nasa"
        bool encontrada = BuscarPalabra(matriz, palabra);

        // Mostrar el resultado
        Console.WriteLine(encontrada
            ? $"La palabra '{palabra}' se encuentra en la matriz."
            : $"La palabra '{palabra}' no se encuentra en la matriz.");
    }

    static bool BuscarPalabra(char[,] matriz, string palabra)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                // Verificar en todas las direcciones
                if (BuscarEnDireccion(matriz, palabra, i, j, 1, 0) || // Horizontal
                    BuscarEnDireccion(matriz, palabra, i, j, 0, 1) || // Vertical
                    BuscarEnDireccion(matriz, palabra, i, j, 1, 1) || // Diagonal derecha abajo
                    BuscarEnDireccion(matriz, palabra, i, j, 1, -1))   // Diagonal izquierda abajo
                {
                    // La palabra se encontró en alguna dirección
                    return true; 
                }
            }
        }
         return false; 
    }

    static bool BuscarEnDireccion(char[,] matriz, string palabra, int fila, int columna, int dirFila, int dirColumna)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int longitud = palabra.Length;

        int filaFinal = fila + (longitud - 1) * dirFila;
        int columnaFinal = columna + (longitud - 1) * dirColumna;

        if (filaFinal >= 0 && filaFinal < filas && columnaFinal >= 0 && columnaFinal < columnas)
        {
            for (int i = 0; i < longitud; i++)
            {
                if (matriz[fila + i * dirFila, columna + i * dirColumna] != palabra[i])
                {
                    return false;
                }
            }

            return true;
        }

        return false;
    }
}