using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = { 5, 15, 12, 18, 28 };

            double total = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                total += notas[i];
            }
            double promedio = total / notas.Length;
            total = 0;
            for (int i = 0; i < notas.Length; i++)
            {

                total += (promedio - notas[i]) * (promedio - notas[i]);

            }
            double desviacion = Math.Sqrt(total / notas.Length);
            Console.WriteLine(desviacion);
        }
    }
}
