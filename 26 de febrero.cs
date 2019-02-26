using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) 
            {
            Random aleatorio = new Random();

            int dado = 0;
            int dadoExtra = 0;
            string continuar = "s";
            int vidas = 3;
            int turnos = 0;

            while (continuar == "s" && vidas > 0) 
                {
                turnos += 1;
                dado = aleatorio.Next(1, 7);
                Console.WriteLine("Dado = " + dado);
                
                 if (turnos % 3 == 0) 
                    {
                      
                      dadoExtra = aleatorio.Next(1, 7);
                      Console.WriteLine("Dado extra = " + dadoExtra);
                      
                      if(dadoExtra == dado) 
                        {
                        vidas += 1;
                        Console.WriteLine("Ganaste una vida, tienes " + vidas + " vidas");
                        }
                      
                    }

                 if (turnos % 2 == 0) 
                    {
                    vidas -= 1;
                    Console.WriteLine("Perdiste una vida, tienes " + vidas + " vidas");
                    }

                 if (vidas == 0) {
                    Console.WriteLine("Tienes 0 vidas");
                    Console.WriteLine("Perdiste");
                    break;
                }

                Console.WriteLine("¿Deseas continuar?  (s/n)");
                continuar = Console.ReadLine();
               
            }

            if (continuar == "n") 
                {
                Console.WriteLine("Gracias por participar");
            }

            


        }
    }
}
