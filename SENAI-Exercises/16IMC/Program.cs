using System;

namespace _16IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine();
            
            System.Console.WriteLine("Digite seu peso (em Kg): ");
            double peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine();

            System.Console.WriteLine("Digite sua altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());
            System.Console.WriteLine();

            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                System.Console.WriteLine($"{nome} está abaixo do peso");
            }
            
            else if ((imc >= 20) && (imc <= 25))
            {
                System.Console.WriteLine($"{nome} está normal");
            }

            else if ((imc > 25) && (imc <= 30))
            {
                System.Console.WriteLine($"{nome} está com excesso de peso");
            }

            else if ((imc > 30) && (imc <= 30))
            {
                System.Console.WriteLine($"{nome} está obeso");
            }

            else if (imc > 35)
            {
                System.Console.WriteLine($"{nome} está com obesidade mórbida");
            }
        }
    }
}
