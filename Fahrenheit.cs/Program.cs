using System;

namespace Fahrenheit.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese grado celsius: ");

            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fahrenheit: " + Convert.ToDecimal(celsius * 1.8 + 32));

            Console.ReadKey();
        }
    }
}
