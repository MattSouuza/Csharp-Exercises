using System;
using System.Collections.Generic;

namespace _26VetorNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            System.Console.Write("Digite a quantidade de nomes que deseja: ");
            int nomeQuant = int.Parse(Console.ReadLine()); 
            string[] nomeInput = new string[nomeQuant];

            for(int i = 0; i < nomeQuant; i++)
            {
                System.Console.Write("Digite um nome qualquer: ");
                nomeInput[i] = Console.ReadLine();
                nomes.Add(nomeInput[i]);
            }

            System.Console.Write("Os nomes digitados foram: ");
            foreach(string x in nomes)
            {
                System.Console.Write(x + "   ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("A quantidade de nomes digitados foram de {0}", nomeQuant);
        }
    }
}
