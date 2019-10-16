using System;
using EscolaDoRosq.Interfaces;

namespace EscolaDoRosq.Models
{
    public class Bateria : instrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mnatendo o ritmo da Bateria");
            return true;
        }
    }
}