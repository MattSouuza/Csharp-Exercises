using System;

namespace _19ArrayLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numerosArray;

            System.Console.WriteLine("Digite N números: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                System.Console.WriteLine(numerosArray[i]);
            }

            Array.Sort(numerosArray);
        }
    }
}
