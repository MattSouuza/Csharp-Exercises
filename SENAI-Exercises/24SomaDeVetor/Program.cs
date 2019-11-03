using System;

namespace _24SomaDeVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = 0;
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arrSum = new int[10];

            System.Console.WriteLine();

            for(int arr1Value = 0; arr1Value < arr1.Length; arr1Value++)
            {
                rndNumber = rnd.Next(1, 100);
                arr1[arr1Value] = rndNumber;
                System.Console.Write("Vetor1[{0}] = {1}  ", arr1Value, rndNumber);
            }

            System.Console.WriteLine();

            for(int arr2Value = 0; arr2Value < arr2.Length; arr2Value++)
            {
                rndNumber = rnd.Next(1, 100);
                arr2[arr2Value] = rndNumber;
                System.Console.Write("Vetor2[{0}] = {1}  ", arr2Value, rndNumber);
            }

            System.Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                arrSum[i] = arr1[i] + arr2[i];
                System.Console.Write("Vetor3[{0}] = {1}  ", i, arrSum[i]);
            }

            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}
