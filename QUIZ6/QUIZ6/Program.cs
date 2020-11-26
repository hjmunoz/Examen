using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7. Diseñe un programa que ayude a calcular la nota de este taller 
             * (7 ejercicios) en donde evalue si las 
             * notas ingresadas estan dentro del rango (0-5) y 
             * devuelva el promedio y ademas si "aprobo" o "no aprobo".*/
            //Variables

            string calificacion;
            double punto_1;
            double punto_2;
            double punto_3;
            double punto_4;
            double punto_5;
            double punto_6;
            double punto_7;

            Console.WriteLine("DIGITE LAS CALIFICACIONES POR PUNTO");
            Console.WriteLine("DIGITE LA CALIFICACION DEL PUNTO 1");
            punto_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE LA CALIFICACION DEL PUNTO 2");
            punto_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE LA CALIFICACION DEL PUNTO 3");
            punto_3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE LA CALIFICACION DEL PUNTO 4");
            punto_4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE LA CALIFICACION DEL PUNTO 5");
            punto_5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE LA CALIFICACION DEL PUNTO 6");
            punto_6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("DIGITE LA CALIFICACION DEL PUNTO 7");
            punto_7 = Convert.ToDouble(Console.ReadLine());
            double suma = (punto_1+punto_2+punto_3+punto_4+punto_5+punto_6+punto_7);
            double Total = (suma/7);
            if (Total >= 3.0)
            {
                calificacion = ("Aprobo");
            }
            else
            {
                calificacion = ("No aprobo");
            }

            Console.WriteLine("LA CALIFICACION TOTAL ES: " + Total);
            Console.WriteLine(calificacion);


            int metodo;

            Console.WriteLine("ingrese el metodo\n  1=efectivo\n  2=contado");
            metodo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(metodo);

            if (metodo == 1)

                Console.WriteLine("cerdo" + 1);

            Console.ReadKey();


        }
    }
}
