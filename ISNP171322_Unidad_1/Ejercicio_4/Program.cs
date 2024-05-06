using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, numero, suma = 0;

            do
            {
                Console.WriteLine("** Bienvenidos a su caculadora de memoria **");
                Console.WriteLine("Le pedira 5 números para almacenarlos y sumarlos al final");
                Console.Write("Introduce el número #" + (i + 1) + ": ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                i++;
            } while (i < 5);

            Console.WriteLine("La suma de los 5 números introducidos es: " + suma);
            Console.ReadKey();  
        }
    }

}
