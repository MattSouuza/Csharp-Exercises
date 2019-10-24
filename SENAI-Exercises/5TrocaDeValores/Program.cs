using System;

namespace _5TrocaDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Oi";
            string b = "Tchau";
            string armazena;

            armazena = a;
            a = b;
            b = armazena;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }
    }
}
