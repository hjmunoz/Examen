using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace QUIZ._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Droguerias Don Pepito desea un programa para ingresar el valor de compra y calcular lo siguiente: 
            si el pago se efectúa al “contado”, calcular un descuento del 5%; pero si el pago es con “tarjeta” 
            se incrementa un recargo del 3% al valor de compra. Calcular y visualizar el descuento o recargo según 
            sea el caso y el total a pagar de la compra.*/
            //Variable
            double valor_compra;
            string metodo_pago;

            Console.WriteLine("BIENVENIDO A DROGUERIA DON PEPITO");
            Console.WriteLine("ingrese el valor de la compra");
            valor_compra = Convert.ToDouble(Console.ReadLine());
            double contado = Convert.ToDouble(valor_compra * 0.05);
            double tarjeta = Convert.ToDouble(valor_compra * 0.03);
            Console.WriteLine("Ingrese el metodo de pago");
            metodo_pago = Console.ReadLine();

            if (metodo_pago == "contado")
            {
                double T = valor_compra - contado;
                Console.WriteLine("El total de su compra: " + T);

                Console.Clear();
                Console.WriteLine("/--------TOTAL COMPRA--------/\n" +
                                 "/VALOR PAGADO " + valor_compra + "\n" +
                                 "/METODO DE PAGO " + metodo_pago + "\n" +
                                 "/DESCUENTO " + contado + "\n" +
                                 "/TOTAL COMPRA " + T + "\n" +
                                 "/----------------------------/\n"
                                 );
            }

            else
            {
                double T = valor_compra + tarjeta;
                Console.WriteLine("El total de su compra: " + T);

                Console.Clear();
                Console.WriteLine("/--------TOTAL COMPRA--------/\n" +
                                  "/VALOR PAGADO " + valor_compra + "\n" +
                                  "/METODO DE PAGO " + metodo_pago + "\n" +
                                  "/RECARGO " + tarjeta +"\n"+
                                  "/TOTAL COMPRA " + T + "\n" +
                                  "/----------------------------/\n"
                                  );
            }
                              
                              
                Console.ReadKey();
        }
    }
}
