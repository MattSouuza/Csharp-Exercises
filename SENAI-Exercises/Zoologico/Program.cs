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
            int opcaoNumber = 0;
            string menuBar = "===========================";
            System.Console.WriteLine(menuBar);
            System.Console.WriteLine(" Zoológico de Bacanolândia");
            System.Console.WriteLine(menuBar);

            foreach(var item in Menu.menuAnimal.Values)
            {
                System.Console.WriteLine($"{opcaoNumber++} - {item.Value}");
            }
        }
    }
}
