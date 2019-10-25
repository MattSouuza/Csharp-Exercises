using System;

namespace _16IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Digite seu peso (em Kg): ");
            int peso = int.Parse(ConsoleReadLine());
            System.Console.WriteLine("Digite sua altura (em metros): ");
            int altura = int.Parse(ConsoleReadLine());

            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                
            }
        }
    }
}
