using System.Collections.Generic;

namespace Reciclagem.Models
{
    public abstract class Deposito
    {
        public static Dictionary<int, Lixo> LixoLista = new Dictionary<int, Lixo>()
        {
            { 1, new Garrafa()},
            { 2, new GarrafaPET()},
            { 3, new GuardaChuva()},
            { 4, new Latinha()},
            { 5, new Papelao()},
            { 6, new PoteManteiga()},
        };

        public static List<string> LixoListaVisivel = new List<string>()
        {
            {"Garrafa"},
            {"Garrafa PET"},
            {"Guarda Chuva"},
            {"Latinha"},
            {"Papelão"},
            {"Pote De Manteiga"}
        };
    }
}