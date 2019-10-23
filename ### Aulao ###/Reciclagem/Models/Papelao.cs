using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Lixo, IAzul
    {
        public bool LixoPapel()
        {
            Console.WriteLine("Esse papelão pertence à lixeira azul.")
            return true;
        }
    }
}