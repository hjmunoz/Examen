using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Realize un programa que simule un inicio de sesión solicitando el nombre de usuario y contraseña,
            y muestre un mensaje en pantalla, inicio de sesión correcto/ nombre de usuario incorrecto.
            */
            //Variables
            string Usuario, u;
            int c = 0, Contraseña;

            u = ("Hector");
            c = 123789;
            Console.WriteLine("Digite el usuario");
            Usuario = (Console.ReadLine());
            Console.WriteLine("Digite la contraseña");
            Contraseña = Convert.ToInt32(Console.ReadLine());

            if (Usuario == u && Contraseña == c)
            {
                Console.WriteLine("Inicio de sesion correcto");
            }
            else
            {
                Console.WriteLine("Usuario o contraseña incorrecto");
            }
            Console.ReadKey();
        }
    }
}
