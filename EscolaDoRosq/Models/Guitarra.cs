using EscolaDoRosq.Interfaces;

namespace EscolaDoRosq.Models
{
    public class Guitarra : instrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Mantendo o ritmo da Guitarra");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine();
            return true;
        }
    }
}