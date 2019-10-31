using System;

namespace _21Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money = new int[] {100, 50, 20, 10, 5, 2};
            
            System.Console.WriteLine("Digite o valor a ser sacado: ");
            int value = int.Parse(Console.ReadLine());

            if(value > 0)
            {
                int notas100 = value / money[0];
                int resto =  value - (value * money[0]); 

                int notas50 = resto / money[1];
                resto = resto - (notas50 * money[1]);

                int notas20 = resto / money[2];
                resto = resto - (notas20 * money[2]);

                int notas10 = resto / money[3];
                resto = resto - (notas50 * money[3]);

                int notas5 = resto / money[4];
                resto = resto - (notas20 * money[4]);

                int notas2 = resto / money[5];
                resto = resto - (notas20 * money[5]);

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
