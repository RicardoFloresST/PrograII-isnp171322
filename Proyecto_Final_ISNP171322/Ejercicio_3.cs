using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitamos al usuario que ingrese su nombre
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // Verificamos si el nombre es "David" y mostramos el mensaje correspondiente
        if (nombre.ToLower() == "david")
        {
            Console.WriteLine("Hola, David.");
        }
        else
        {
            Console.WriteLine("No te conozco.");
        }

        // Esperamos a que el usuario presione Enter antes de cerrar la consola
        Console.ReadLine();
    }
}