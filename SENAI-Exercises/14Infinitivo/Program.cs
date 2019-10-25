using System;

namespace _14Infinitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um verbo qualquer no infintivo: ");
            string verbo = Console.ReadLine();

            verbo.ToLower();
            
            if(verbo.EndsWith("ar"))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Este verbo está no infinito, 1° conjugação");
            }

            if(verbo.EndsWith("er"))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Este verbo está no infinito, 2° conjugação");
            }
            
            if(verbo.EndsWith("ir"))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Este verbo está no infinito, 3° conjugação");
            }

            else
            {
                System.Console.WriteLine($"{verbo} não está no infinito");
            }
        }
    }
}
