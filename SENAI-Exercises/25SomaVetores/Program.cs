using System;

namespace _25SomaVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o tamanho do primeiro vetor: ");
            int input1 = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o tamanho do segundo vetor: ");
            int input2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            int input3 = input1 + input2;

            int[] arr1 = new int[input1];
            int[] arr2 = new int[input2];
            int[] arr3 = new int[input3];
            Random rnd = new Random();

            for(int i = 0; i < input1; i++)
            {
                arr1[i] = rnd.Next(1, 100);
                System.Console.WriteLine("Vetor1[{0}] = {1}", i, arr1[i]);
            }

            System.Console.WriteLine();

            for(int i= 0; i< input2; i++)
            {
                arr2[i] = rnd.Next(1, 100);
                System.Console.WriteLine("Vetor2[{0}] = {1}", i, arr2[i]);
            }

            System.Console.WriteLine();

            int count = 0;
            for(int i = 0; i < input1; i++)
            {
                arr3[count++] = arr1[i];
            }

            for(int i = 0; i < input2; i++)
            {
                arr3[count++] = arr2[i];
            }

            for(count = 0; count < input3; count++)
            {
                System.Console.WriteLine($"Vetor3[{count}] = {arr3[count]}");
            }
        }
    }
}
