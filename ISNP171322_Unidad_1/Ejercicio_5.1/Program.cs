using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, suma = 0, cont = 0;
            double promedio;

            Console.WriteLine("Introduce una serie de números ya sean enteros o reales (introduce 0 para finalizar):");

            while (true)
            {
                Console.Write("Introduce un número: ");
                num = double.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    break;
                }

                suma += num;
                cont++;
            }

            if (cont > 0)
            {
                promedio = (double)suma / cont;
                Console.WriteLine("El promedio de los números introducidos es: " + promedio);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se introdujeron números válidos.");
                Console.ReadKey();
            }
        }
    }

}