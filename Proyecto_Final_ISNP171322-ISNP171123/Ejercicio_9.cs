using System;

public class MostrarNumeros
{
   public static void Main(string[] args)
    {
        //Mostramos un saludo
        Console.WriteLine(" **++** Bienvenidos la aplicación de comprobación de números UGB **++** ");

        string respuesta;

        do
        {
            // Solicitamos al usuario que ingrese un número
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Verificamos si el número es par o impar y mostramos el resultado
            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }

            // Preguntamos al usuario si desea ingresar otro número
            Console.Write("¿Desea ingresar otro número? (si/no): ");
            respuesta = Console.ReadLine();

        } while (respuesta.ToLower() == "si");

        // Esperamos a que el usuario presione Enter antes de cerrar la consola
        Console.WriteLine("Programa cerrado.");
        Console.ReadLine();
    }
}