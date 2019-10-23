using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Início

            bool quersair = false;

            string menuBar = "==============================";

            #endregion

            do{
                #region Controla o menu dos lixos
                
                    Console.Clear();
                    
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("  Seja Bem-vindo(a) ao LIXO!  ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    System.Console.WriteLine();
                    System.Console.WriteLine(menuBar);
                    System.Console.WriteLine("Escolha um lixo");
                    System.Console.WriteLine("1 - Garrafa");
                    System.Console.WriteLine("2 - Garrafa PET");
                    System.Console.WriteLine("3 - Guarda Chuva");
                    System.Console.WriteLine("4 - Latinha");
                    System.Console.WriteLine("5 - Papelão");
                    System.Console.WriteLine("6 - Pote de Manteiga");
                    System.Console.WriteLine("0 - Sair");
                    System.Console.WriteLine(menuBar);
                    System.Console.WriteLine();

                    int opcaoEscolhido = int.Parse(Console.ReadLine());

                    if(opcaoEscolhido != 0)
                    {
                        var output = Deposito.lixosLista[opcaoEscolhido];
                        System.Console.WriteLine(output);
                        
                    } else {
                        System.Console.WriteLine("Saindo ...");
                        quersair = true;
                    }

                #endregion
            } while(!quersair);
        }
    }
}