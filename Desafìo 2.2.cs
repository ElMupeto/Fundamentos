﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un ángulo a y el valor de la hipotenusa");
            double agrados = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double a = agrados * (Math.PI / 180.0);
            Console.WriteLine("Para un triángulo rectángulo los datos resultantes serían");
            Console.WriteLine("Sen(a) = y/h asi que y = sen(a)*h");
            double y = Math.Sin(a) * h;
            Console.WriteLine("cateto1 =" + y);
            Console.WriteLine("Cos(c) = y/h asi que c = arccos(y/h)");
            double c = Math.Acos(y / h) * (180.0 / Math.PI);
            Console.WriteLine("ángulo c =" + c);
            double cgrados = c * (Math.PI / 180.0);
            Console.WriteLine("Sen(c) = z/h asi que z = sen(c)*h");
            double z = Math.Sin(cgrados) * h;
            Console.WriteLine("cateto2 =" + z);
            Console.WriteLine("ángulo b =90");
        }
    }
}
