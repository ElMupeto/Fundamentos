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

            int[] union = new int[conj1.Length + conj2.Length];



            for (int i = 0; i < conj1.Length; i++) {


                union[i] = conj1[i];

            }

            for (int i = conj1.Length; i < union.Length; i++) {


                union[i] = conj2[i - conj1.Lenght];

            }

            Console.WriteLine("la union es ");

            for (int i = 0; i < union.Length; i++) {


                Console.WriteLine("" + union[i]);


            }



        }

    }

}
