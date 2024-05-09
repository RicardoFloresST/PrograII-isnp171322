using System;

public class MostrarRaizCuadrada
{
    public static void Main(string[] args) {
        // Mostrar un Saludo
        Console.WriteLine("**--** Bienvenidos al Programa Mostrar Cuadrado UGB **--** ");

        string respuesta;

        do
        {
            double numero;

            do
            {
                // Solicitamos al usuario que ingrese un número
                Console.Write("Ingrese un número mayor que cero: ");
                
                // Intentamos convertir la entrada del usuario a un número
                if (!double.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    // Si la conversión falla o el número es menor o igual a cero, mostramos un mensaje de error
                    Console.WriteLine("ERROR. Reingresar número.");
                }
                else
                {
                    // Si el número es válido, calculamos su cuadrado y lo mostramos
                    double cuadrado = Math.Pow(numero, 2);
                    Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
                }
            } while (numero <= 0);

            // Preguntamos al usuario si desea ingresar otro número
            Console.Write("¿Quieres ingresar otro número? (si/no): ");
            respuesta = Console.ReadLine();

        } while (respuesta.ToLower() == "si");

        // Esperamos a que el usuario presione Enter antes de cerrar la consola
        Console.WriteLine("Programa cerrado.");
        Console.ReadLine();
    }
}