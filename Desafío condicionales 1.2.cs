using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_condicionales_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de salario
            Console.WriteLine("Ingrese su salario en cuestión de smmlv. Teniendo en cuenta que 1 smmlv = 828,116 COP");
            int salario = int.Parse(Console.ReadLine());

            //Condicionales respecto al número de smmlv que gana el usuario

            if (salario < 2)
            {
                Console.WriteLine("Tarifa A");
                Console.WriteLine("Cuota moderadora = 3.200");

            }

            else if (2 <= salario && salario < 5)
            {
                Console.WriteLine("Tarifa B");
                Console.WriteLine("Cuota moderadora = 12.700");
            }

            else
            {
                Console.WriteLine("Tarifa C");
                Console.WriteLine("Cuota moderadora = 33.500");
            }
        }
    }
}
