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
            double[] desviacion = new double[notas.Length];


            double total = 0;
            double totalDes = 0;
            double DesEstan = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                total += notas[i];
            }

            double promedio = total / notas.Length;


            for (int i = 0; i < notas.Length; i++)
            {
                desviacion[i] = notas[i] - promedio;
            }

            for (int i = 0; i < notas.Length; i++)
            {
                desviacion[i] = Math.Pow(desviacion[i], 2);
            }

            for (int i = 0; i < notas.Length; i++)
            {
                totalDes += desviacion[i];
            }

            DesEstan = Math.Sqrt(totalDes / notas.Length);

            Console.WriteLine(promedio);
            Console.WriteLine(DesEstan);

            /*Manera mas facil de hacerla, más optimizada
             
              int total = 0
   for (int i = 0; i < notas.Length; i ++) {
                total += notas[i]; 
                Console.WriteLine(total);
            }
            double promedio = total / edades.Length;
            total = 0;
            for (int i = 0; i < edades.Length; i ++) {

                total += (promedio - edades[i]) * (promedio - edades[i]);

            }
            double desviacion = Math.Sqrt(total /notas.Length); */


        }
    }
}
