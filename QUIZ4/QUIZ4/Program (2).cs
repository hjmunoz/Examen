using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Diseñe un programa que lea la temperatura en centígrados del día e imprima el tipo de clima de acuerdo
             * a la siguiente tabla. 
             * (Use condicional múltiple) 
             * Temperatura <= 10 Frio
             * 10 < Temperatura <= 20 Templado
             * 20 < Temperatura <= 30 Calido
             * Temperatura > 30 Vamos pa la playa*/
            //Variables.
            
            string clima;
            double temperatura;

            Console.WriteLine("INGRESE LA TEMPERATURA");
            temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura <= 10)
            {
                clima = ("La temperatura es "+"Frio");
            }
            else if (temperatura > 10 && temperatura <= 20)
            {
                clima = ("La temperatura es " + "Templado");
            }
            else if (temperatura > 20 && temperatura <= 30)
            {
                clima = ("La temperatura es "+"Calido");
            }
            else
            {
                clima = ("La temperatura es "+"Vamos pa la playa");
            }
            Console.WriteLine(clima);
                


            Console.ReadKey();

        }
    }
}
