using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. Tiendas Don Pepe desea un programa para ingresar por teclado el monto de compra y el día de la semana;
             * si el día es martes o jueves, se realizará un descuento del 15% por la compra. Visualizar el descuento y 
             * el total a pagar por la compra.*/
            //Variables.
            double compra = 0;
            string dia_semana = "";


            Console.WriteLine("BIENVENIDOS A TIENDAS DON PEPE");
            Console.WriteLine("INGRESE EL VALOR DE LA COMPRA");
            compra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("INGRESE EL DIA DE LA SEMANA");
            dia_semana = Console.ReadLine();
            double descuentom = (compra * 0.15);
            if (dia_semana == "martes")

            {
                double Total = (compra - descuentom);
                Console.Clear();
                Console.WriteLine("/----------VALOR COMPRA----------/\n" +
                                  "/" + compra + "\n" +
                                  "/DIA DE LA COMPRA " + dia_semana+"\n" +
                                  "/DESCUENTO " + descuentom + "\n" +
                                  "/--------------------------------/\n" +
                                  "/TOTAL COMPRA " + Total + "\n" +
                                  "/--------------------------------/\n" 
                                  );
            }
            else if (dia_semana == "jueves")
            {
                double Total = (compra - descuentom);
                Console.Clear();
                Console.WriteLine("/----------VALOR COMPRA----------/\n" +
                                  "/" + compra + "\n" +
                                  "/DIA DE LA COMPRA " + dia_semana + "\n" +
                                  "/DESCUENTO " + descuentom + "\n" +
                                  "/--------------------------------/\n" +
                                  "/TOTAL COMPRA " + Total + "\n" +
                                  "/--------------------------------/\n"
                                  );


            }
            else
            {
                double Total = (compra);
                Console.Clear();
                Console.WriteLine("/----------VALOR COMPRA----------/\n" +
                                  "/" + compra + "\n" +
                                  "/DIA DE LA COMPRA " + dia_semana + "\n" +
                                  "/DESCUENTO " + 0 + "\n" +
                                  "/--------------------------------/\n" +
                                  "/TOTAL COMPRA " + Total + "\n" +
                                  "/--------------------------------/\n"
                                  );





            }
                Console.ReadKey();

        }
    }
}
