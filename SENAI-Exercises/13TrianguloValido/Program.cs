using System;

namespace _13TrianguloValido
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o tamanho de um lado de um triângulo: ");
            int lado1 = int.Parse(Console.ReadLine());
            System.Console.Write("Insira o tamanho de outro lado: ");
            int lado2 = int.Parse(Console.ReadLine());
            System.Console.Write("Insira o tamanho de um outro lado: ");
            int lado3 = int.Parse(Console.ReadLine());

            bool trianguloValido = false;
            if(lado1 < (lado2 + lado3) || lado2 < (lado1 + lado3) || lado3 < (lado2 + lado1))
            {
                System.Console.WriteLine();
                System.Console.WriteLine("É um triângulo válido");
                trianguloValido = true;
            } else {
                System.Console.WriteLine();
                System.Console.WriteLine("Não é um triângulo válido");
                trianguloValido = false;
            }

            if(trianguloValido == true)
            {
                if(lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Este triângulo é Equilátero");
                }

                if(lado1 == lado2 && lado1 != lado3 || lado1 == lado3 && lado1 !=lado2 || lado2 == lado3 && lado2 !=lado1)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Este triângulo é Isósceles");
                }

                if(lado1 != lado2 && lado1 !=lado3 && lado2 != lado3 || lado1 != lado3 && lado1 !=lado2 && lado3 != lado2 || lado2 != lado3 && lado2 !=lado1 && lado1 !=lado3)
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("Este triângulo é Escaleno");
                }
            }
        }
    }
}
