using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarjeta_
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio;
            string metpago;
            double numtarjeta;

            Console.Write("Escriba el precio del producto: ");
            precio = double.Parse(Console.ReadLine());

            Console.Write("Escriba el metodo de pago: ");
            metpago = (Console.ReadLine());

            if (metpago.Equals("tarjeta"))
            {
                Console.Write("Digite el numero de la tarjeta: ");
                numtarjeta = double.Parse(Console.ReadLine());
                
                if(numtarjeta < 0)
                {
                    Console.WriteLine("Valores incorrectos, porfavor intentelo denuevo");
                }
                else
                {
                Console.WriteLine("El producto con precio " + precio + " se ha pagado" + 
                " con el numero cuenta " + numtarjeta);
                }
            }

            else if (metpago.Equals("efectivo"))
            {
                Console.WriteLine("El producto con precio " + precio + " se ha pagado correctamente!");
            }

            else
            {
                Console.WriteLine("El metodo de pago no es valido");
            }
            Console.ReadKey();

        }
    }
}
