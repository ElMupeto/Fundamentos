using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos 
            Console.WriteLine("Ingrese a,b & c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //Cálculo de discriminane
            double discriminante = (b * b) - (4 * a * c);

            if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x es igual: " + x);
            }

            else if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("x1 es igual: " + x1);
                Console.WriteLine("x2 es igual: " + x2);

            }

            else
            {
                Console.WriteLine("No es posible solucionarlo");
            }

        }
    }
}
