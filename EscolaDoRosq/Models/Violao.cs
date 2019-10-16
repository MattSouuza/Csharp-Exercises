using System;
using EscolaDoRosq.Interfaces;

namespace EscolaDoRosq.Models
{
    public class Violao : instrumentoMusical, IHarmonia, IMelodia, IPercussao
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de violão");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do Violão");
            return true;
        }

        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Violão");
            return true;
        }
    }
}