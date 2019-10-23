using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Lixo, IAzul
    {
        public bool LixoPapel()
        {
            System.Console.WriteLine($"{this.GetType().Name} é reciclagem");
            Console.WriteLine("Esse papelão pertence à lixeira azul.");
            return true;
        }
    }
}