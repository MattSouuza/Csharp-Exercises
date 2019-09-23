using System;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {
            double year = 0;
            double age = 0;
            
            do {
                Console.WriteLine("Digite o ano em que nasceu:");
                year = double.Parse(Console.ReadLine());
                if ((year > 2019) || (year < 0)) {
                    Console.WriteLine("Data Inválida");
                }
            } while (year > 2019);

            age = 2019 - year;

            Console.Write("Você tem ");
            Console.Write(age);
            Console.Write(" de idade,");

            if (age < 3){
                Console.WriteLine(" Você é um recém-nascido");
            }

            else if ((age >= 3) && (age <= 11)) {
                Console.WriteLine(" Você é uma criança");
            }

            else if ((age >= 12) && (age <=19)) {
                Console.WriteLine(" Você é um adolescente");
            }

            else if ((age >= 20) && (age <=60)) {
                Console.WriteLine(" Você é um adulto");
            }

            else if ((age >= 60) && (age <666)) {
                Console.WriteLine(" Você é um idiota");
            }

            else if (age == 666) {
                Console.WriteLine(" Você é o CAPETA");
            }
        }
    }
}
