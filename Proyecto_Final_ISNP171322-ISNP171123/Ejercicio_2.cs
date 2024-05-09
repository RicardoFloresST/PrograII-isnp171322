using System;

class sumaNumeros
{
    static void Main(string[] args)
    {
        // Inicializamos la variable suma
        int suma = 0;

        Console.WriteLine("Ingrese números positivos para calcular la suma (ingrese un número negativo o cero para terminar).");

        // Ciclo para ingresar números y calcular la suma
        while (true)
        {
            // Solicitamos al usuario que ingrese un número
            Console.Write("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Verificamos si el número es positivo
            if (num > 0)
            {
                // Sumamos el número a la suma total
                suma += num;
            }
            else
            {
                // Si el número ingresado es cero o negativo, terminamos el bucle
                break;
            }
        }

        // Mostramos la suma total
        Console.WriteLine($"La suma de los números positivos ingresados es: {suma}");

        // Esperamos a que el usuario presione Enter antes de cerrar la consola
        Console.ReadLine();
    }
}