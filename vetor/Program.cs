using System;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[6];

            Console.WriteLine("Digite o 1° número: ");
            number[0] = int.Parse(Console.ReadLine());

            if (number[0] % 2 == 0) {
                Console.WriteLine("É um número par");
            } else {
                Console.WriteLine("É um número impar");
            }

            Console.WriteLine("Digite o 2° número: ");
            number[1] = int.Parse(Console.ReadLine());

            if (number[1] % 2 == 0) {
                Console.WriteLine("É um número par");
            } else {
                Console.WriteLine("É um número impar");
            }

            Console.WriteLine("Digite o 3° número: ");
            number[2] = int.Parse(Console.ReadLine());
            
            if (number[2] % 2 == 0) {
                Console.WriteLine("É um número par");
            } else {
                Console.WriteLine("É um número impar");
            }

            Console.WriteLine("Digite o 4° número: ");
            number[3] = int.Parse(Console.ReadLine());

            if (number[3] % 2 == 0) {
                Console.WriteLine("É um número par");
            } else {
                Console.WriteLine("É um número impar");
            }

            Console.WriteLine("Digite o 5° número: ");
            number[4] = int.Parse(Console.ReadLine());

            if (number[4] % 2 == 0) {
                Console.WriteLine("É um número par");
            } else {
                Console.WriteLine("É um número impar");
            }

            Console.WriteLine("Digite o 6° número: ");
            number[5] = int.Parse(Console.ReadLine());

            if (number[5] % 2 == 0) {
                Console.WriteLine("É um número par");
            } else {
                Console.WriteLine("É um número impar");
            }
        }
    }
}