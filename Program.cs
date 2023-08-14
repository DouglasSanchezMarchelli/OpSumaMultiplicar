using System;

namespace SumarMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumar numero 1 + numero 2 y  Producto numero 3 * numero 4");
           

            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            double num4 = double.Parse(Console.ReadLine());

            double suma = num1 + num2;
            double producto = num3 * num4;

            Console.WriteLine("Suma de los dos primeros números es " +suma);
            Console.WriteLine("Producto del tercer número con el cuarto número es " +producto);
        }
    }
}
