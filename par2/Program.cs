using System;

namespace par
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            
            do{

                Console.WriteLine("Insira qualquer número INTEIRO ou digite 0 para parar: ");
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0 ) {
                    Console.WriteLine("Este número é par");
                }

                else {
                    Console.WriteLine("Este número é impar");
                }

                } while (number != 0);
             
        }
    }
}
