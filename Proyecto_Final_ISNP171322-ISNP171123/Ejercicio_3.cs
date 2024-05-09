using System;

class sueldoMayor
{
    static void Main(string[] args)
    {
        // Definimos variables para almacenar el nombre y el sueldo del operario con el sueldo mayor
        string nombreMayor = "";
        double sueldoMayor = double.MinValue;

        // Solicitamos al usuario que ingrese los nombres y sueldos de los operarios
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese el nombre del operario {i}: ");
            string nombre = Console.ReadLine();

            Console.Write($"Ingrese el sueldo del operario {i}: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            // Verificamos si el sueldo ingresado es mayor que el sueldo mayor actual
            if (sueldo > sueldoMayor)
            {
                // Si es así, actualizamos el nombre y el sueldo mayor
                nombreMayor = nombre;
                sueldoMayor = sueldo;
            }
        }

        // Mostramos el nombre y el sueldo mayor
        Console.WriteLine($"El operario con el sueldo mayor es: {nombreMayor}");
        Console.WriteLine($"Su sueldo es: {sueldoMayor}");

        // Esperamos a que el usuario presione Enter antes de cerrar la consola
        Console.ReadLine();
    }
}