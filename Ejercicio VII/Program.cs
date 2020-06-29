/*Un programa que pida al usuario 4 números, los memorice (utilizando una tabla), calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.
*/
using System;
using System.ComponentModel;

namespace EJERCICIO_SEM_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular la medida aritmetica de 4 numeros");

            int i = 0, j = 1, auxacum=0;

            int[] numeros = new int[4];

            Console.WriteLine("Ingrese los 4 numeros que quisiera operar");

            do
            {

                Console.WriteLine("Ingrese el numero de la posicion #{0} :", j);
                j++;
                numeros[i] = int.Parse(Console.ReadLine());
                ++i;
            }
            while (i < 4);
            Console.WriteLine(" ");

            Console.WriteLine("Los numeros digitados son");


            foreach (int a in numeros)
            {

                Console.Write("  #" + a);
                auxacum += a;
               
            }
            Console.WriteLine(" ");

            Console.WriteLine("La media de estos 4 numero son : "+ (auxacum/4));


        }

    }
}
