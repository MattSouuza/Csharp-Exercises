using System;

namespace par
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            Console.WriteLine("Insira qualquer número INTEIRO: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 ) {
                Console.WriteLine("Este número é par");
            }

            else {
                Console.WriteLine("Este número é impar");
            }
        }
    }
}
