/*
 Un programa que almacene en una tabla el número de días que tiene cada mes (de un año no bisiesto),
 pida al usuario que le indique un mes (ej. 2 para febrero) y un día (ej. el día 15) y diga qué número de día es dentro del año 
 (por ejemplo, el 15 de febrero sería el día número 46, el 31 de diciembre sería el día 365).

 */
using System;
using System.Diagnostics;

namespace Ejercicio_V
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int mes, dia,contdd=0;
            //cantidad de dias por mes
            int [] numeroMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //nombre de los meses

            string  [] nombremeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            Console.WriteLine("Programa para detallar las fechas ");

            do
            {
                Console.WriteLine("Digita el dia :");
                dia = int.Parse(Console.ReadLine());

                Console.WriteLine("Digita el mes :");


                mes = int.Parse(Console.ReadLine());
                if (dia < 0 || dia > 31 && mes < 0 || mes > 12)
                {

                    Console.WriteLine("Error , el dia o el mes estan incorrectos , trate de nuevo");
                }
            } while (dia < 0 || dia > 31 && mes < 0 || mes > 12);

            mes--;


            for (int i=0; i <= mes; ++i)
            {
                if (mes < 1)
                {
                    contdd = dia;
                    break;
                }
                
                else if (i == mes)
                {
                    numeroMeses[mes] = dia;
                }
                
                
                contdd +=numeroMeses[i];
            }

            
            
            Console.WriteLine("Usted eligio el mes {0} dia {1} y es el dia #{2}/365", nombremeses[mes], dia, contdd);
        }
    }
}


