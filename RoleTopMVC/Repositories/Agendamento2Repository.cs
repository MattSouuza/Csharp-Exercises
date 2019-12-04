using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class Agendamento2Repository
    {
        private const string PATH = "Database/Agendamento.csv";

        public Agendamento2Repository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento agendamento1)
        {
            var linha = new string[] {FazerRegistroCSV(agendamento1)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        private string FazerRegistroCSV(Evento a2)
        {
            Cliente c = a2.Cliente;

            return $"evento_nome={a2.NomeEvento};evento_tipo={a2.TipoEvento};evento_status={a2.StatusEvento};planos={a2.Planos};numero_pessoas={a2.NumeroPessoas};data_evento={a2.DataEvento};hora_inicio={a2.HoraInicio};hora_termino={a2.HoraTermino};descricao={a2.Descricao}";
        }
    }
}