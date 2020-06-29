/*
 Un programa que almacene en una tabla el número de días que tiene cada mes (supondremos que es un año no bisiesto), 
 pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.

 */
using System;
using System.Collections.Generic;

namespace Ejercicio_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            int selmes;
            var mesydia = new Dictionary<int, int>
            {
                {1,31},
                {2,28},
                {3,31},
                {4,30},
                {5,31},
                {6,30},
                {7,31},
                {8,31},
                {9,30},
                {10,31},
                {11,30},
                {12,31}
            };
            Console.WriteLine("Programa para saber el numero de dias que tiene cada mes");

            
            do
            {
                Console.Write("Seleccione el mes, teniendo en cuenta que 1=enero , 2=enero ... etc.");
                selmes = int.Parse(Console.ReadLine());

                if (selmes < 0 || selmes > 12)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Error, mes invalido");
                
                }
            } while (selmes < 0 && selmes > 12);

            Console.WriteLine("El mes {0} tiene {1} dias", selmes, mesydia[selmes]);
        }
    }
}
