using System;

public class Tabla_Multiplicacion
{
    public static void Main(string[] args)
    {
        // Mostramos un mensaje para indicar qué hace el programa
        Console.WriteLine("Tabla de multiplicar del 0 al 10:");

        // Utilizamos un bucle for externo para iterar a través de los multiplicadores del 0 al 10
        for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
        {
            // Mostramos un encabezado para la tabla de multiplicar actual
            Console.WriteLine($"Tabla de multiplicar del {multiplicador}:");

            // Utilizamos un bucle for interno para iterar a través de los multiplicandos del 0 al 10
            for (int multiplicando = 1;
            multiplicando <= 10; multiplicando++)
            {
                // Calculamos el resultado de la multiplicación y lo mostramos en la consola
                int resultado = multiplicador * multiplicando;
                Console.WriteLine($"{multiplicador} x {multiplicando} = {resultado}");
            }

            // Agregamos una línea en blanco para separar las tablas de multiplicar
            Console.WriteLine();
        }

        // Esperamos a que el usuario presione Enter antes de cerrar la consola
        Console.ReadLine();
    }
}