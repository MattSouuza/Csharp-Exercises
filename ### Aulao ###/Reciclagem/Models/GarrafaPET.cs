using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GarrafaPET : Lixo, IVermelho
    {
        public bool LixoPlastico()
        {
            System.Console.WriteLine($"{this.GetType().Name} é reciclagem");
            System.Console.WriteLine("Esse lixo plástico pertence à lixeira vermelha");
            return true;
        }
    }
}