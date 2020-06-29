/*
 Crear un programa que pida al usuario la fecha, detallando el día (1 al 31) y el mes (1=enero, 12=diciembre)
 luego muestre en pantalla el número de días que quedan hasta final de año.
 */
using System;

namespace Ejercicio_VI
{
    class Program
    {
        static void Main(string[] args)
        {

            int mes, dia, contdd = 0;
            //cantidad de dias por mes
            int[] numeroMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            //nombre de los meses

            string[] nombremeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

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


            for (int i = 0; i <= mes; ++i)
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


                contdd += numeroMeses[i];
            }

            contdd -= 365 ;
            contdd *= -1;

            Console.WriteLine("Usted eligio el mes {0} dia {1} y faltan {2} dias para que se acabe el año", nombremeses[mes], dia, contdd);
        }
    }
}
