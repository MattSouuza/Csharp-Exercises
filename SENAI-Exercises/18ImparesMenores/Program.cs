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
                    num -=2;
                    System.Console.Write(num + " ");
                } while(num > 1);
            } 

            else if(num % 2 == 0)
            {
                num -= 1;
                do
                {
                    num -=2;
                    System.Console.Write(num + " ");
                } while (num > 1);
            }
        }
    }
}
