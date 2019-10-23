using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class PoteManteiga : Lixo, IVermelho
    {
        public bool LixoPlastico()
        {
            Console.WriteLine("Esse plástico pertence à lixeira vermaelha")
            return true;
        }
    }
}