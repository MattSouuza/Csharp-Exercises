using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class PoteManteiga : Lixo, IVermelho
    {
        public bool LixoPlastico()
        {
            System.Console.WriteLine($"{this.GetType().Name} é reciclagem");
            Console.WriteLine("Esse plástico pertence à lixeira vermaelha");
            return true;
        }
    }
}