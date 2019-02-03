using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            double porcriesgo = 0;

            //Entrada de datos: Salario, tipo de contrato, equivalencia al riesgo si el contraro es dependiente
            Console.WriteLine("Dijite su salario en cuestión de smmlv mínimo, nosotros calcularemos el total" +
                "\nEscriba 1 si su contrato es dependiente & 2 si su contrato es de tipo independiente");
            double smmlv = double.Parse(Console.ReadLine());
            double salario = smmlv * 828116.0;
            Console.WriteLine("Su salario total es de:" + salario);
            int contrato = int.Parse(Console.ReadLine());

            if(contrato == 2)
            {
                Console.WriteLine("Si su contrato es de tipo indepentiente, escriba un número de 1-5 dependiendo de su equivalencia de riesgo");
                int riesgo = int.Parse(Console.ReadLine());

                //Asignación de porcentaje según riesgo
                if (riesgo == 1)
                {
                    porcriesgo = 0.0522;
                }
                else if (riesgo == 2)
                {
                    porcriesgo = 0.1033;
                }
                else if (riesgo == 3) 
                {
                    porcriesgo = 0.2436;
                }
                else if (riesgo == 4)
                {
                    porcriesgo = 0.4350;
                }
                else
                {
                    porcriesgo = 0.6960;
                }
            }

            


            //Cálculo base de cotización

            double basecot = (salario * 0.4);

            if(basecot < 828116.0)
            {
                basecot = 828116.0;
            }
            else
            {
               basecot = (salario * 0.4);
            }
        
            //Salario real mensual 

            if(contrato == 1)
            {
                double deducPension = (basecot * 0.04);
                double deducEPS = (basecot * 0.04);
                double salariomensual = salario - deducEPS - deducPension;
                Console.WriteLine("Su salario real es de: " + salariomensual);
                double salarioanual = salario + (salariomensual * 12);
                Console.WriteLine("Su salario anual es de: " + salarioanual);
            }

            else if (contrato == 2)
            {
                double deducPension = (basecot * 0.16);
                double deducEPS = (basecot * 0.125);
                double deducARL = (basecot * porcriesgo);
                double salariomensual = salario - deducEPS - deducPension - deducARL;
                Console.WriteLine("Su salario real es de: " + salariomensual);
                double salarioanual = (salariomensual * 12);
                Console.WriteLine("Su salario anual es de: " + salarioanual);
            }
            

            
        }
    }
}
