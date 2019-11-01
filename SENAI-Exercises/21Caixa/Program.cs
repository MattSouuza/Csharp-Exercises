using System;

namespace _21Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor a ser sacado: ");
            int value;

            if(int.TryParse(Console.ReadLine(), out value))
            {
                int notas100 = value /100;
                int resto =  value - (value * 100); 

                int notas50 = resto / 50;
                resto = resto - (notas50 * 50);

                int notas20 = resto / 20;
                resto = resto - (notas20 * 20);

                int notas10 = resto / 10;
                resto = resto - (notas10 * 10);

                int notas5 = resto / 5;
                resto = resto - (notas5 * 5);

                int notas2 = resto / 2;
                resto = resto - (notas2 * 2);

                System.Console.WriteLine($"Quantidade notas de 100 {notas100}.");
                System.Console.WriteLine($"Quantidade notas de 50 {notas50}.");
                System.Console.WriteLine($"Quantidade notas de 20 {notas20}.");
                System.Console.WriteLine($"Quantidade notas de 10 {notas10}.");
                System.Console.WriteLine($"Quantidade notas de 5 {notas5}.");
                System.Console.WriteLine($"Quantidade notas de 2 {notas2}.");
            }
        }
    }
}
