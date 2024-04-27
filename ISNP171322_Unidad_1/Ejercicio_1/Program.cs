using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                Console.Write("Introduzca un número para verificar si es positivo o negativo ó 0 para salir: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                if (num > 0)
                {
                    Console.WriteLine("El número {0} es positivo.", num);
                }
                else
                {
                    Console.WriteLine("El número {0} es negativo.", num);
                }
            }

            Console.WriteLine("Programa terminado.");
            Console.ReadKey();
        }
    }
}