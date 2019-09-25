using System;

namespace newteste
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = 0;
            int alt = 0;
            string ast = "*";
            string ast2 = "*";

            Console.WriteLine("Digite a quantidade de triangulos desejados: ");
            qtd = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do triangulo");
            alt = int.Parse(Console.ReadLine());

            while(qtd != 0){

                for (int i = 0; i < alt; i++){
                    ast += ast2;
                    Console.WriteLine("*");
                }

                ast2 = "*";
                qtd--; 
            }
        }
    }
}
