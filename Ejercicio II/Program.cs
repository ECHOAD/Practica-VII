/*
Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") y luego los muestre en el orden contrario al que se introdujeron.
*/
using System;
using System.Globalization;
using System.Linq;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];

            for (int i = 0, j = 1; i < 5; ++i ,j++)
            {
                Console.WriteLine("Ingrese el numero de la posicion #{0}", j);
                numeros[i] = float.Parse(Console.ReadLine());
            }

            Array.Reverse(numeros);
            Console.WriteLine(" ");

            Console.WriteLine("Los numeros al reves son");

            foreach (float a in numeros)
            {
                Console.Write(" #"+ a);
            }
        }


    }
}
