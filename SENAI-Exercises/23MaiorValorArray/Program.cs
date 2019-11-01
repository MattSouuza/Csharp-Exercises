using System;

namespace _23MaiorValorArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randomArray = new int[10];

            for(int i = 0; i < 10; i++)
            {
                randomArray[i] = random.Next(0, 1000);
                System.Console.WriteLine("Array[{0}] = {1}", i, randomArray[i]);
            }

            int maoirNum = randomArray[0];
            int menorNum = randomArray[0];

            foreach(int num in randomArray)
            {
                if(num > maoirNum)
                {
                    maoirNum = num;
                } else if(num < menorNum)
                {
                    menorNum = num;
                }
            }

            System.Console.WriteLine("Maior número é {0} e menor número é {1}", maoirNum, menorNum);
        }
    }
}
