using System;

namespace _10DivisivelPor3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira um número qualquer: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            if(number % 3 == 0)
            {
                System.Console.WriteLine($"{number} é divisível por 3");
            } else {
                System.Console.WriteLine($"{number} não é divisível por 3");
            }
        }
    }
}
