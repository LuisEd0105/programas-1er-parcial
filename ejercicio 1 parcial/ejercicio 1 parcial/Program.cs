using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1_parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Escribe un dia de la semana: ");
                String dia = Console.ReadLine();

                switch (dia)
                {
                    case "lunes":
                    case "martes":
                    case "miercoles":
                    case "jueves":
                    case "viernes":

                        Console.WriteLine("No es fin de semana");
                        break;

                    case "sabado":
                    case "domingo":

                        Console.WriteLine("Es fin de semana");
                        break;
                }
            }
            Console.WriteLine("\nPresione enter para finalizar");
            Console.ReadKey();
        }
        }
    }