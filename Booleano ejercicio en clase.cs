using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleano {
    class Program {
        static void Main(string[] args) {
            //Ingreso de datos
            Console.WriteLine("Ingrese votos para el partido a y b respectivamente");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número votos anulados y votos en blanco");
            int anulado = int.Parse(Console.ReadLine());
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la población total y el porcentaje que es mayor de edad");
            int poblaciontotal = int.Parse(Console.ReadLine());
            int porcentaje = int.Parse(Console.ReadLine());

            int abstinencia = poblaciontotal - a - b - anulado - blanco; 
            int numerovotantes = a + b + anulado + blanco;
            //Creación booleanos
            bool anulados = anulado < ((a + b) * 0.3);
            bool votosblanco = (a + b) > blanco;
            bool abstinenciatotal = abstinencia < numerovotantes;

            //Datos buscados
            if ((anulados || votosblanco) && abstinencia < numerovotantes)
                {
                 Console.WriteLine("La votación fue exitosa");
                  if(a > b) 
                    {
                    Console.WriteLine("Gana el partido 1");
                    }
                else 
                    {
                    Console.WriteLine("Gana el partido 2");
                    }
                }
            else {
                Console.WriteLine("La votación debe ser realizada nuevamente");
            }



        }
    }
}
