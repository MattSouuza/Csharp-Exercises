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
            int[] arrSum = new int[10]

            for(int arr1Value = 0; arr1Value < arr1.Length; arr1Value++)
            {
                rndNumber = rnd.Next(1, 100);
                arr1[arr1Value] = rndNumber;
                System.Console.WriteLine("Vetor1[{0}] = {1}", arr1Value, rndNumber);
            }

            System.Console.WriteLine();

            for(int arr2Value = 0; arr2Value < arr2.Length; arr2Value++)
            {
                rndNumber = rnd.Next(1, 100);
                arr2[arr2Value] = rndNumber;
                System.Console.WriteLine("Vetor2[{0}] = {1}", arr2Value, rndNumber);
            }

            for(int arrSum)
        }
    }
}
