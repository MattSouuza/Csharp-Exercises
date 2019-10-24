using System;

namespace _9Gravidade
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Insira o seu peso: ");
            double pTerra = double.Parse(Console.ReadLine());

            System.Console.WriteLine("O seu peso é " + pTerra + "Kg");

            System.Console.WriteLine("Escolha um planeta e veja o seu peso lá");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Mercúrio");
            System.Console.WriteLine("2 - Vênus");
            System.Console.WriteLine("3 - Marte");
            System.Console.WriteLine("4 - Júpiter");
            System.Console.WriteLine("5 - Saturno");
            System.Console.WriteLine("6 - Urano");
            System.Console.WriteLine("7 - Netuno");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                double gMercurio = 0.37;
                double pPlaneta = (pTerra / 10) * gMercurio;
                System.Console.WriteLine(pPlaneta);

                break;

                case "2":
                double gVenus = 0.88;
                pPlaneta = (pTerra / 10) * gVenus;
                System.Console.WriteLine(pPlaneta);

                break;

                case "3":
                double gMarte = 0.38;
                pPlaneta = (pTerra / 10) * gMarte;
                System.Console.WriteLine(pPlaneta);

                break;

                case "4":
                double gJupiter = 2.64;
                pPlaneta = (pTerra / 10) * gJupiter;
                System.Console.WriteLine(pPlaneta);

                break;

                case "5":
                double gSaturno = 1.15;
                pPlaneta = (pTerra / 10) * gSaturno;
                System.Console.WriteLine(pPlaneta);

                break;

                case "6":
                double gUrano = 0.92;
                pPlaneta = (pTerra / 10) * gUrano;
                System.Console.WriteLine(pPlaneta);

                break;

                case "7":
                double gNetuno = 1.19;
                pPlaneta = (pTerra / 10) * gNetuno;
                System.Console.WriteLine(pPlaneta);

                break;

                default:
                System.Console.WriteLine("Saindo...");
                break;
            }


        }
    }
}
