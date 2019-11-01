using System;

namespace _19ArrayLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numerosArray = new int[100];

            System.Console.Write("Digite o tamanho do array : ");
            int n = int.Parse(Console.ReadLine());

            if(n >= 100)
            {
                System.Console.WriteLine($"Você não quer digitar {n} vezes, confie em mim....");
            } else {
                for(int i = 1; i <= n; i++)
                {
                    System.Console.WriteLine("Digite um número qualquer: ");
                    numerosArray[i] = int.Parse(Console.ReadLine());
                }

                for(int i = 1; i <= n; i++)
                {
                    System.Console.WriteLine("Os elementos na array são: {0}", numerosArray[i]);
                }
            }
        }
    }
}
