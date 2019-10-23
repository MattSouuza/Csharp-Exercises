using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem
{
    enum LixoListaEnum : int
    {
        Garrafa,
        GarrafaPET,
        GuardaChuva,
        Latinha,
        Papelão,
        PoteManteiga
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Início

            bool quersair = false;

            var lixoLista = Enum.GetNames(typeof(LixoListaEnum));
            //var itensMenuPrincipal = Deposito.LixoListaVisivel;

            string menuBar = "==============================";

            #endregion

            do{
                #region Controla o menu dos lixos

                bool LixoEscolhido = false;
                do{
                    Console.Clear();
                    
                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Seja Bem-vindo(a) ao LIXO!");
                    System.Console.WriteLine("Escolha um lixo      ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    //System.Console.WriteLine(itensMenuPrincipal);
                    System.Console.WriteLine(lixoLista);
                    System.Console.WriteLine("Ou digite 0 para sair.");
                    string opcaoSair = Console.ReadLine();

                    switch (opcaoSair)
                    {
                        case "0":
                            System.Console.WriteLine("Saindo ...");
                            LixoEscolhido = true;
                        break;
                        default:
                        System.Console.WriteLine("Ação inválida");
                        break;
                    }
                }while(!LixoEscolhido);

                #endregion
            } while(!quersair);
        }
    }
}