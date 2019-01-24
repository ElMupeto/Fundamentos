using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cateto1 Y cateto2");
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Para un triángulo rectángulo los datos resultantes serían");
            double h = Math.Sqrt((y * y) + (z * z));
            Console.WriteLine("Hipotenusa =" + h);
            Console.WriteLine("Sen(a) = z/h asi que a = arcseno(z/h)");
            double a = Math.Asin(z / h) * (180.0 / Math.PI);
            Console.WriteLine("ángulo a =" + a);
            Console.WriteLine("Sen(a) = y/h asi que a = arcseno(y/h)");
            double c = Math.Asin(y / h) * (180.0 / Math.PI);
            Console.WriteLine("ángulo c =" + c);
            Console.WriteLine("ángulo b =90");
        }
    }
}
