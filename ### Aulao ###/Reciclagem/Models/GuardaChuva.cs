using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : Lixo, ICinza
    {
        public bool LixoIndefinido()
        {
            System.Console.WriteLine($"{this.GetType().Name} é reciclagem");
            System.Console.WriteLine("Esse lixo é indefinido, pertence à lixeira cinza.");
            return true;
        }
    }
}