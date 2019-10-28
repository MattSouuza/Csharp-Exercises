using System;

namespace _20RandomArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Random random = new Random();
            int[] randomList = new int[10];
            
            for(int i = 0; i < 10; i++)
            {
                num = random.Next(1, 100);
                randomList[i] = num;
                System.Console.Write(num + " ");
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine();

            for(int i = 0; i < 10; i++)
            {
                if(randomList[i] % 2 == 0)
                {
                    System.Console.WriteLine(randomList[i] + " é par");
                }
            }

            System.Console.WriteLine();

            for(int i = 0; i < 10; i++)
            {
                if(randomList[i] % 2 != 0)
                {
                    System.Console.WriteLine(randomList[i] + " é impar");
                }
            }
        }
    }
}
