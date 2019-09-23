using System;

namespace areas
{
    class Program
    {
        static void Main(string[] args)
        {

            string option;

            Console.WriteLine("Digite uma das figuras abaixo: ");
            Console.WriteLine("Quadrado");
            Console.WriteLine("Triângulo");
            Console.WriteLine("Círculo");
            Console.WriteLine("Trapézio");
            Console.WriteLine("Retângulo");
            Console.WriteLine("Losango");
            Console.WriteLine("Digite a figura escolhida: ");
            option = Console.ReadLine();

            switch (option){
                case "Quadrado":
                    Console.WriteLine("Área do quadrado: ");
                    Console.Write("Entre com o valor dos lados: ");
                    double ladoQ = double.Parse(Console.ReadLine());
                    double areaQ = ladoQ * ladoQ;
                    Console.WriteLine("O valor da área é: " + areaQ);
                    break;

                case "Triângulo":
                    Console.WriteLine("Área do Triângulo: ");
                    Console.Write("Entre com o valor da base: ");
                    double baseTri = double.Parse(Console.ReadLine());
                    Console.Write("Entre com o valor da altura: ");
                    double altTri = double.Parse(Console.ReadLine());
                    double areaTri = baseTri * altTri;
                    Console.WriteLine("O valor da área é: " + areaTri);
                    break;

                case "Círculo":
                    Console.WriteLine("Área do Círculo: ");
                    Console.Write("Entre com o valor do raio: ");
                    double raio = double.Parse(Console.ReadLine());
                    double areaC = 3.14 * raio ;
                    Console.WriteLine("O valor da área é: " + areaC);
                    break;

                case "Trapézio":
                    Console.WriteLine("Área do Trapézio: ");
                    Console.Write("Entre com o valor da base maior: ");
                    double trapMaior = double.Parse(Console.ReadLine());
                    Console.Write("Entre com o valor da base menor: ");
                    double trapMenor = double.Parse(Console.ReadLine());
                    Console.Write("Entre com o valor da altura: ");
                    double trapAlt = double.Parse(Console.ReadLine());
                    double areaTrap = (trapMaior + trapMenor) * trapAlt / 2;
                    Console.WriteLine("O valor da área é: " + areaTrap);
                    break;

                case "Retângulo":
                    Console.WriteLine("Área do Trapézio: ");
                    Console.Write("Entre com o valor da base: ");
                    double baseRet = double.Parse(Console.ReadLine());
                    Console.Write("Entre com o valor do lado menor: ");
                    double altRet = double.Parse(Console.ReadLine());
                    double areaRet = baseRet * ladoRet;
                    Console.WriteLine("O valor da área é: " + areaRet);
            }
        }
    }
}
