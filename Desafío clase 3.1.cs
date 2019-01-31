using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Ingrese su peso y altura
            Console.WriteLine("Ingrese su peso y altura");
            double peso = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());

            //Calculamos IMC
            double IMC = (peso / (altura * altura));
            Console.WriteLine("Su IMC es de " + IMC);

            if ( 18.5 <= IMC && IMC <= 24.9){

                Console.WriteLine("Normal :)");
            }

            else if (IMC < 18.5)
            {
                Console.WriteLine("Bajo de peso");
            }

            else if (25 <= IMC && IMC <= 29.9)
                {
                Console.WriteLine("Sobrepeso");
            }

            else {
                Console.WriteLine("Obesidad");
            }
        }
    }
}
