using System;

namespace _11AlfabeticalOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[2];

            System.Console.Write("Insira um nome: ");
            string nome1 = Console.ReadLine();
            System.Console.Write("Insira outro nome: ");
            string nome2 = Console.ReadLine();

            nomes [0] = nome1;
            nomes [1] = nome2;

            Array.Sort(nomes);
            foreach(string i in nomes)
            {
                Console.WriteLine(i);
            }
        }
    }
}
