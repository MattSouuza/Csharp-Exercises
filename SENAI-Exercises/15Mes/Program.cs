using System;

namespace _15Mes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número correspondente a algum mês: ");
            string mes = Console.ReadLine();

            switch(mes)
            {
                case "1":
                System.Console.WriteLine($"O mês {mes} é janeiro");
                break;

                case "2":
                System.Console.WriteLine($"O mês {mes} é fevereiro");
                break;

                case "3":
                System.Console.WriteLine($"O mês {mes} é março");
                break;

                case "4":
                System.Console.WriteLine($"O mês {mes} é abril");
                break;

                case "5":
                System.Console.WriteLine($"O mês {mes} é maio");
                break;

                case "6":
                System.Console.WriteLine($"O mês {mes} é junho");
                break;

                case "7":
                System.Console.WriteLine($"O mês {mes} é julho");
                break;

                case "8":
                System.Console.WriteLine($"O mês {mes} é agosto");
                break;

                case "9":
                System.Console.WriteLine($"O mês {mes} é setembro");
                break;

                case "10":
                System.Console.WriteLine($"O mês {mes} é outubro");
                break;

                case "11":
                System.Console.WriteLine($"O mês {mes} é novembro");
                break;

                case "12":
                System.Console.WriteLine($"O mês {mes} é dezembro");
                break;
                
                default:
                System.Console.WriteLine($"Não existe nenhum mês correspondente a {mes}");
                break;
            }
        }
    }
}
