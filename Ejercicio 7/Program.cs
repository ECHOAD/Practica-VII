
/*
 Un programa que pida al usuario 10 números, calcule su media y luego muestre los que están por encima de la media.

 */
using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa de la media para 10 numeros");

            double[] numeros = new double[10];
            double media=0;

            for (int i=0,j=1; i<10; ++i ,j++)
            {
                Console.WriteLine("Digite el numero #" + j);
                numeros[i] = Double.Parse(Console.ReadLine());

                if (i == 9)
                {
                    media += numeros[i];
                    media /= 10;
                }
                else
                {
                    media += numeros[i];
                }
             
            }

            
            Console.WriteLine(" La media es {0}, y Los numeros mas grande que la media son: ",media);

            foreach (double a in numeros)
            {
                if (a > media)
                {
                    Console.Write(" #" + a);
                }
            }


        }
    }
}
