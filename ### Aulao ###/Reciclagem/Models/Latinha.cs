using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Latinha : Lixo, IAmarelo
    {
        public bool LixoMetal()
        {
            System.Console.WriteLine($"{this.GetType().Name} é reciclagem");
            System.Console.WriteLine("Esse metal pertence à lixeira amarela.");
            return true;
        }
    }
}