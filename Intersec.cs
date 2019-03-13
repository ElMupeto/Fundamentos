using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7 {
    class Program {
        static void Main(string[] args) {
            int[] conj1 = { 0, 3, 6, 9, 12, 15, 18 };
            int[] conj2 = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            int[] union = new int[17];
            int[] inter = new int[31];
            int interr = 0;


            Console.WriteLine("interseccion entre conjuntos");

            for (int b = 0; b < conj2.Length; b += 1) // Revise las veces que sean necesarias y no se salga del ancho 
            {
                for (int c = 0; c < conj1.Length; c += 1) {


                    if (conj2[b] == conj1[c]) {



                        inter[interr] = conj2[b];
                        Console.WriteLine(inter[interr]);
                        interr += 1;

                    }


                }

            }

        }

    }

}
