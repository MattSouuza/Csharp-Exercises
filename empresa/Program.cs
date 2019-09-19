using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double wage = 0;
            double value = 0;

            Console.Write("Digite o valor do seu salário: ");
            wage = double.Parse(Console.ReadLine());

            value = wage / 30;

            if (wage < 500) {
                Console.WriteLine($"{wage} + {value} = {wage + value}");
            }
            
            else {
                Console.WriteLine("Seu salário não sofrerá aumento, porque ultrapassa o valor mínimo.");
            }
        }
    }
}
