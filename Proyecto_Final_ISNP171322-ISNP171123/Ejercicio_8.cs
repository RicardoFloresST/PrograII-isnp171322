using System;

public class mostrarNumero{
    public static void Main(string[] args) {

         Console.WriteLine(" **++** Bienvenidos la aplicación de comprobación de números UGB **++** ");

        string respuesta;
        
        do {
            // Solicitamos al usuario que ingrese un número
            Console.Write("Ingrese un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            // Verificamos si el número es positivo, negativo o cero y mostramos el resultado
            if (numero > 0)
            {
                Console.WriteLine("El número ingresado es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número ingresado es negativo.");
            }
            else
            
            {
                Console.WriteLine("El número ingresado es cero.");
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

