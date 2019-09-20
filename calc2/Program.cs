using System;

namespace calc2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            string oper; 

            Console.WriteLine("Digite o 1º número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número:");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador:");
            oper = Console.ReadLine();

            if (oper == "+") {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");           
            }

            else if (oper == "-") {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }

            else if (oper == "*") {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }

            else if (oper == "/") {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }

            else {
                Console.WriteLine("Operação Inválida");
            }

           /* switch (oper){
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;

                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;

                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;

                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break; 

                default {
                    Console.WriteLine("Operação Inválida");
                break;
                }

            } */ 

            }
        }
    }