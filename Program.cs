using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesly_Prueba_Tecnica_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teatro teatro = new Teatro();
            int opcion;

            do
            {
                Console.WriteLine("-------------------- Sistema de Reserva de Asientos --------------------\n");
                Console.WriteLine("1. Ver mapa de asientos");
                Console.WriteLine("2. Reservar un asiento");
                Console.WriteLine("3. Salir");
                Console.Write("\nSeleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        teatro.MostrarMapa();
                        break;
                    case 2:
                        teatro.ReservarAsiento();
                        break;
                    case 3:
                        Console.WriteLine("Gracias por usar el sistema. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

            } while (opcion != 3);
        }
    }
}
    

