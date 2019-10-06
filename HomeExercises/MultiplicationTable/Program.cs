using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Type a number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine();

            for (int m = 0; m <= 10; m++)
            {
                System.Console.WriteLine($"{number} * {m} = {number * m}");
            }
        }
    }
}
    /**
    * ! "if" NÃO é laço, então não use como se fosse! Use "for", "while" etc 
    */