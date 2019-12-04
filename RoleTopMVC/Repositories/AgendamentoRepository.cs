using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class AgendamentoRepository
    {
        private const string PATH = "Database/Agendamento.csv";

        public AgendamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento agendamento)
        {
            var linha = new string[] {FazerRegistroCSV(agendamento)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        private string FazerRegistroCSV(Evento agendamento)
        {
            Cliente c = agendamento.Cliente;
            Evento a = agendamento;

            return $"cliente_nome={c.Nome};cliente_cpf={c.Cpf};cliente_email={c.Email};cliente_telefone={c.Telefone};evento_nome={a.NomeEvento};evento_tipo={a.TipoEvento};evento_status={a.StatusEvento};planos={a.Planos};numero_pessoas={a.NumeroPessoas};data_evento={a.DataEvento};hora_inicio={a.HoraInicio};hora_termino={a.HoraTermino};descricao={a.Descricao}";
        }
    }
}