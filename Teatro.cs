using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesly_Prueba_Tecnica_01
{
    internal class Teatro
    {
        
        private const int Filas = 10;
        private const int AsientosPorFila = 10;
        private char[,] asientos;

        public Teatro()
        {
            asientos = new char[Filas, AsientosPorFila];
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < AsientosPorFila; j++)
                {
                    asientos[i, j] = 'L'; 
                }
            }
        }

        public void MostrarMapa()
        {
            Console.Clear();
            Console.WriteLine("---- Mapa de Asientos ----\n");

            for (int i = 0; i < Filas; i++)
            {
                Console.Write("Fila " + (i + 1) + ": ");
                for (int j = 0; j < AsientosPorFila; j++)
                {
                    Console.Write(asientos[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ReservarAsiento()
        {
            Console.Write("\nIngrese el número de fila (1-10): ");
            int fila = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Ingrese el número de asiento (1-10): ");
            int asiento = int.Parse(Console.ReadLine()) - 1;

            if (fila >= 0 && fila < Filas && asiento >= 0 && asiento < AsientosPorFila)
            {
                if (asientos[fila, asiento] == 'L')
                {
                    asientos[fila, asiento] = 'X';
                    Console.WriteLine("¡Reserva exitosa! Asiento marcado como ocupado.");
                }
                else
                {
                    Console.WriteLine("El asiento ya está reservado. Elija otro asiento.");
                }
            }
            else
            {
                Console.WriteLine("El número de fila o asiento está fuera de rango.No somos enfermeria para hacer reventa");
            }
        }
    }
}
    

