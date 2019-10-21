using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem
{
    enum LixoEnum : int
    {
        Garrafa = 1,
        GarrafaPET,
        GuardaChuva,
        Latinha,
        Papelao,
        PoteDeManteiga
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Início

            bool quersair = false;
            string[] itensMenuPrincipal = Dictionary.LixoLista;

            // var opcaoLixo = new List<string>()
            //{
                //"   - 0                 ",
                //"   - 1                 "
            //};

            int opcaoLixoSelecionado = 0;

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
                    System.Console.WriteLine("      Seja Bem-vindo(a) ao LIXO!");
                    System.Console.WriteLine("           Escolha um lixo      ");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    System.Console.WriteLine(itensMenuPrincipal);



                }while(!LixoEscolhido);

                #endregion
            } while(!quersair);
        }
    }
}
