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
            //var itensMenuPrincipal = Deposito.LixoListaVisivel;

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

                    var opcaoEscolhido = Menu.MostrarMenu();

                    Menu.MostrarMenu();

                    switch (opcaoEscolhido)
                    {
                        case 1:
                            Garrafa.LixoPlastico();
                        break;
                    }
                    

                #endregion
            } while(!quersair);
        }
    }
}