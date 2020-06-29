/*
Un programa que almacene los días de la semana en un array y luego mostrarlo.
*/

using System;

namespace Ejercicio_III
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Dias de la semana mostrado por pantalla");
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            foreach (string a in dias)
            {
                Console.Write("-"+a);
            }
            Console.ReadKey();
            
        }
    }
}
