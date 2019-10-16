using EscolaDoRosq.Interfaces;

namespace EscolaDoRosq.Models
{
    public class Teclado : instrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando o solo do Teclado");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine();
            return true;
        }
    }
}