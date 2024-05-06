using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, suma = 0;

            do
            {
                Console.WriteLine("Bienvenidos a la calculadora UGB");
                Console.Write("Introduce un número positivo (0 o si ingresas un número negativo termina el programa): ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    suma += numero;
                }
            } while (numero > 0);

            Console.WriteLine("La suma de todos los números positivos introducidos es: " + suma);
            Console.WriteLine("** Gracias por utilizar nuestra calculadora UGB **");
            Console.ReadKey();
        }
        
      
    }
    

}