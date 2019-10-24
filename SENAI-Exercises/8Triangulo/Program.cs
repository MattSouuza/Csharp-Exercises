using System;

namespace _8Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira a altura do triângulo: ");
            int altura = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

        for (int row = 0; row <= altura; ++row)
        {
            for (int col = altura; col > row; --col)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        }
    }
}
