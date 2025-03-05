using System;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        int suma = numero1 + numero2;

        Console.WriteLine("La suma de los dos números es: " + suma);
    }
}
