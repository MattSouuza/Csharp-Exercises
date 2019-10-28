using System;

namespace RetanguloOper
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o valor da base do retângulo: ");
            double baseR = double.Parse(Console.ReadLine());
            
            System.Console.Write("Insira o valor da altura do retângulo: ");
            double alturaR = double.Parse(Console.ReadLine());

            double perimetro = (2 * baseR) + (alturaR *2);
            System.Console.WriteLine();
            System.Console.WriteLine($"O resultado do perímetro é {perimetro}");

            double area = baseR * alturaR;
            System.Console.WriteLine();
            System.Console.WriteLine($"O resultado da área é {area}");

            double resultadoDiagonal = (baseR * baseR) + (alturaR * alturaR);
            double diagonal = Math.Sqrt(resultadoDiagonal);
            System.Console.WriteLine();
            System.Console.WriteLine($"O resultado da diagonal é {diagonal}");
            System.Console.WriteLine();
        }
    }
}
