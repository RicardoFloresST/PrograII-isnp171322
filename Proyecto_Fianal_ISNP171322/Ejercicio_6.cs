using System;

public class mostrarPromedio
{
    static void Main(string[] args)
    {
        // Mostrar Saludo
        Console.WriteLine("*** Bienvenidos a la aplicación Mostrar Promedio ***");
        Console.WriteLine("");
        // Mostramos un mensaje para indicar qué hace el programa
        Console.WriteLine("Ingrese 5 números para calcular su promedio:");

        // Creamos una variable para almacenar la suma de los números ingresados
        double suma = 0;

        // Utilizamos un bucle for para solicitar al usuario ingresar 5 números
        for (int i = 1; i <= 5; i++)
        {
            // Solicitamos al usuario que ingrese un número y lo convertimos a double
            Console.Write($"Ingrese el número {i}: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            // Sumamos el número ingresado a la suma total
            suma += numero;
        }

        // Calculamos el promedio dividiendo la suma total entre la cantidad de números ingresados (5)
        double promedio = suma / 5;

        // Mostramos el promedio en la consola
        Console.WriteLine($"El promedio de los 5 números ingresados es: {promedio}");

        // Esperamos a que el usuario presione Enter antes de cerrar la consola
        Console.ReadLine();
    }
}