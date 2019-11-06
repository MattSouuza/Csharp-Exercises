using System;
using System.Linq;
using Zoologico.Models;
using System.Collections.Generic;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            bool encerrouProgram = true;
            do
            {
                string menuBar = "=================================================================================";
                System.Console.WriteLine(menuBar);
                System.Console.WriteLine("|                         Zoológico de Bacanolândia                             |");
                System.Console.WriteLine(menuBar);

                foreach(var item in Menu.menuAnimal)
                {
                    System.Console.Write(item.Key + " - ");
                    System.Console.WriteLine(item.Value.GetType().Name);
                }
                
                System.Console.Write("\nSelecione um número correspondente a um animal: ");

                try
                {
                    int opcaoUsuario = int.Parse(Console.ReadLine());
                    System.Console.WriteLine();
                    var animais = Menu.menuAnimal[opcaoUsuario];
                    //Method here
                    encerrouProgram = true;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Digite um número válido");
                    Console.ReadLine();
                    encerrouProgram = false;
                }
            } while(!encerrouProgram);
        }
    }
}
