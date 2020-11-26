using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6. Diseñe un programa que lea el numero de cedula de la persona e imprima el el valor a cobrar de pasaje
             * en transmilenio.
             * CC = 10 cifras Tarifa plena de $2.500
             * CC < 10 cifras Tarifa adulto mayor de $2.500 - 30%
             * CC = 6 cifras Tarifa adulto muy mayor de $0
             * CC <= 5 cifras o > 10 cifras Pague el doble de la tarifa por tramposo.*/
            //Variables.
            double cc, tarifa;
            double descuento = 750;

            Console.WriteLine("DIGITE EL NUMERO DE LA CEDULA");
            cc = Convert.ToDouble(Console.ReadLine());
            if (cc >= 1000000000 && cc < 10000000000)
            {
                tarifa = (2500);
            }
            else if (cc >= 1000000 && cc < 1000000000)
            {
                tarifa = (2500 - 750);
            }
            else if (cc >= 100000 && cc < 1000000)
            {
                tarifa = (0);
            }
            else
            {
                tarifa = (2500 * 2);
            }
            Console.WriteLine("El costo del pasaje es: "+tarifa);

            Console.ReadKey();

        }
    }
}
