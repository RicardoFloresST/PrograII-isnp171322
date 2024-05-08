using System;

public class mostrarImpares{
    public static void Main(string[] args)
    {
        // Mostramos un mensaje para indicar qué hace el programa
        Console.WriteLine("Mostrando números impares entre 0 y 100:");

        // Utilizamos un bucle for para iterar a través de los números del 1 al 100
        // incrementando de 2 en 2 para asegurarnos de que solo se impriman los números impares
        for (int i = 1; i <= 100; i += 2)
        {
            // Mostramos el número impar actual en la consola
            Console.WriteLine(i);
        }

        // Esperamos a que el usuario presione Enter antes de cerrar la consola
        Console.ReadLine();
    }
}