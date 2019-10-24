using System;

namespace _2Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Insira a temperatura em celsius");
            double c = double.Parse(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine(c + " graus Celsius");
            double f = (9 * c + 160) / 5;
            System.Console.WriteLine(f + " graus Fahrenheit");
        }
    }
}