using System;
using System.Linq;
using System.Collections.Generic;

namespace _22Array3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] randomArray = new int[3,3];


            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    randomArray[i,j] = random.Next(1, 100);
                    System.Console.WriteLine("Array[{0},{1}] = {2}", i, j, randomArray[i,j]);
                }
            }

            int sum = 0;
            foreach(int num in randomArray)
            {
                sum += num;
            }

            System.Console.WriteLine("O total é {0}", sum);
        }
    }
}
