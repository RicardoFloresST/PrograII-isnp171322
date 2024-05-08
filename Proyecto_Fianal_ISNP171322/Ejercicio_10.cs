using System;

public class MostrarNumeros
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calcular la Edad Promedio");
        int suma = 0;
        int cantidadEdades = 15;

        for (int i = 1; i <= cantidadEdades; i++)
        {
            int edad;
            bool entradaValida = false;

            do
            {
                Console.Write($"Edad {i}: ");
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("ERROR: Debe ingresar una edad.");
                    continue;
                }

                if (!int.TryParse(entrada, out edad))
                {
                    Console.WriteLine("ERROR: Debe ingresar un número entero.");
                    continue;
                }

                if (edad <= 0)
                {
                    Console.WriteLine("ERROR: La edad debe ser mayor que cero.");
                    continue;
                }
                if (edad > 115)
                {
                    Console.WriteLine("ERROR: La edad no puede ser mayor que 115.");
                    continue;
                }

                entradaValida = true;
            } while (!entradaValida);

            suma += edad;
        }

        double edadProm = (double)suma / cantidadEdades;
        Console.WriteLine($"Edad Promedio: {edadProm}");
        Console.WriteLine();
        //Mensaje de agradecimiento...
        Console.WriteLine(" *** Gracias por utilizar nuestra aplicación. ***");
        Console.ReadLine();
    }
}