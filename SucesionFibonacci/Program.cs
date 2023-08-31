using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Reto #2
 * LA SUCESIÓN DE FIBONACCI
 * Fecha publicación enunciado: 10/01/22
 * Fecha publicación resolución: 17/01/22
 * Dificultad: DIFÍCIL
 *
 * Enunciado: Escribe un programa que imprima los 50 primeros números de la sucesión de Fibonacci empezando en 0.
 * La serie Fibonacci se compone por una sucesión de números en la que el siguiente siempre es la suma de los dos anteriores.
 * 0, 1, 1, 2, 3, 5, 8, 13...
 */

namespace SucesionFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estos son los primeros 50 numeros de la sucesión de fibonacci: ");
            Fibonacci();
        }        

        private static void Fibonacci()
        {
            long[] sucesion = new long[50];

            sucesion[0] = 0;
            sucesion[1] = 1;
            long suma;

            for (int i = 1; i<49; i++)
            {
                suma = sucesion[i -1] + sucesion[i];
                sucesion[i+1] = suma;
            }

            foreach (long i in sucesion)
            {
                Console.WriteLine(i);
            }
        }        
    }
}
