using EscolaDoRosq.Interfaces;

namespace EscolaDoRosq.Models
{
    public class ContraBaixo : instrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando o Contra Baixo");
            return true;
        }
    }
}