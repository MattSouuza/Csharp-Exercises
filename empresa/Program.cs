using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double wage = 0;
            double value = 0;
            double newWage = 0;

            Console.Write("Digite o valor do seu salário: ");
            wage = double.Parse(Console.ReadLine());

            value = wage * 0.3;
            newWage = value + wage;

            if (wage < 500) {
                Console.WriteLine($"{wage} + {value} = {wage + value}");
                Console.WriteLine("Seu salário sofreu aumento de 30% e agora é " + newWage);
            }
            
            else {
                Console.WriteLine("Seu salário não sofrerá aumento, pois ultrapassa o valor mínimo.");
            }
        }
    }
}