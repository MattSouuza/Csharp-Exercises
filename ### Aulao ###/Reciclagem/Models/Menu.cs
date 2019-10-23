using System.Collections.Generic;
using System;

namespace Reciclagem.Models
{
    public class Menu
    {
        public Menu(){}

        List<string> lixo;

        static public int MostrarMenu()
        {
            string menuBar = "==============================";

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

            var opcaoEscolhido = Console.ReadLine();
            return Convert.ToInt32(opcaoEscolhido);
        } 
    }
}