using System;

namespace _4OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            System.Console.Write("Insira um número qualquer: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                System.Console.WriteLine($"{number} é par");
            } else {
                System.Console.WriteLine($"{number} é impar");
            }
        }
    }
}
