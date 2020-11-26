using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Pida un número entre 0 y 99999 y diga cuantas cifras tiene
            //Variables
            int N = 0;

            Console.WriteLine("Digite un numero entre 0 y 99999");
            N = Convert.ToInt32(Console.ReadLine());
            if (N < 10)
            {
                Console.WriteLine("cantidad de cifras: 1");
            }
            else if (N > 9 && N < 100)
            {
                Console.WriteLine("cantidad de cifras: 2");
            }
            if (N > 99 && N < 1000)
            {
                Console.WriteLine("cantidad de cifras: 3");
            }
            if (N > 999 && N < 10000)
            {
                Console.WriteLine("cantidad de cifras: 4");
            }
            if (N > 9999 && N < 100000)
            {
                Console.WriteLine("cantidad de cifras 5");
            }
            if (N > 99999)
            {
                Console.WriteLine("Recuerde que es un numero entre 0 y 99999");
            }
            Console.ReadKey();
        }
    }
}
