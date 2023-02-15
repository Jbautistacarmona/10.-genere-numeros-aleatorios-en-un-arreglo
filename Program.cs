using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.genere_numeros_aleatorios_en_un_arreglo
{


    class Program
{
    static void Main(string[] args)
    {
        // Creamos un arreglo de tamaño 10 para almacenar los números aleatorios
        int[] numeros = new int[10];

        // Generamos números aleatorios entre 1 y 100
        Random rnd = new Random();
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = rnd.Next(1, 101);
        }

        // Mostramos los números aleatorios generados
        Console.WriteLine("Arreglo original:");
        MostrarArreglo(numeros);
        Console.WriteLine("------------------------------------");

            // Ordenamos el arreglo de manera ascendente usando el método de la burbuja
            OrdenarAscendente(numeros);
        Console.WriteLine("Arreglo ordenado de manera ascendente:");
        MostrarArreglo(numeros);
        Console.WriteLine("------------------------------------");

            // Ordenamos el arreglo de manera descendente usando el método de la burbuja
            OrdenarDescendente(numeros);
        Console.WriteLine("Arreglo ordenado de manera descendente:");
        MostrarArreglo(numeros);
        Console.WriteLine("------------------------------------");
            Console.ReadLine();
    }

    // Método para mostrar los elementos de un arreglo
    static void MostrarArreglo(int[] arreglo)
    {
        foreach (int elemento in arreglo)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }

    // Método para ordenar un arreglo de manera ascendente usando el método de la burbuja
    static void OrdenarAscendente(int[] arreglo)//significa que el método está asociado con la clase, no con una instancia específica (objeto) de esa clase.
        {
        int n = arreglo.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }
    }

    // Método para ordenar un arreglo de manera descendente usando el método de la burbuja
    static void OrdenarDescendente(int[] arreglo)
    {
        int n = arreglo.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arreglo[j] < arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }
 
    }
}

}