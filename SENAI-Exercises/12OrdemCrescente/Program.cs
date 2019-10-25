using System;

namespace _12OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];

            System.Console.Write("Insira um número qualquer: ");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.Write("Insira outro número: ");
            int num2 = int.Parse(Console.ReadLine());
            System.Console.Write("Insira outro número: ");
            int num3 = int.Parse(Console.ReadLine());

            numeros [0] = num1;
            numeros [1] = num2;
            numeros [2] = num3;

            Array.Sort(numeros);
            foreach(int j in numeros)
            {
                System.Console.WriteLine(j);
            }
        }
    }
}
