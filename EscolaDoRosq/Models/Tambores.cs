using EscolaDoRosq.Interfaces;

namespace EscolaDoRosq.Models
{
    public class Tambores : instrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo dos Tambores");
            return true;
        }
    }
}