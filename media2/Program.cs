using System;

namespace mediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1, value2, value3, value4, media;


            
            Console.Write("Digite o 1º valor: ");
            value1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            value2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 3º valor: ");
            value3 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 4º valor: ");
            value4 = double.Parse(Console.ReadLine());

            media = (value1 + value2 + value3 + value4) / 4;

            Console.WriteLine("Sua média é " + media);

            if (media > 7) {
                Console.WriteLine("Aprovado.");
            }
            
            else if ((media == 7) && (media <= 7.5)) {
                Console.WriteLine("Quase foi reprovado! Estude melhor.");
            }

            else {
              Console.WriteLine("Reprovado.");
            }
        }
    }
}