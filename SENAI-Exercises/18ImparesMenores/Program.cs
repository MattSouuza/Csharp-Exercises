using System;

namespace _18ImparesMenores
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira um número qualquer: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 != 0)
            {
                do
                {
                    System.Console.WriteLine(num-=2);
                } while(num > 1);
            } 

            else if(num % 2 == 0)
            {
                System.Console.WriteLine(num-=1);

                do
                {
                    System.Console.WriteLine(num-=2);
                } while (num > 1);
            }
        }
    }
}
