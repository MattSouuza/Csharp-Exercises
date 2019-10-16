using System.Collections.Generic;

namespace EscolaDoRosq.Models
{
    public class Deposito
    {
        public static Dictionary<int, instrumentoMusical> Instrumento = new Dictionary<int, instrumentoMusical>()
        {
            {1, new Baixo()},
            {2, new Bateria()},
            {3, new ContraBaixo()},
            {4, new Guitarra()},
            {5, new Teclado()},
            {6, new Tambores()},
            {7, new Violao()}
        };
    }
}