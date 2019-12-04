using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class Agendamento1Repository
    {
        private const string PATH = "Database/Agendamento.csv";

        public Agendamento1Repository()
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

        private string FazerRegistroCSV(Evento agendamento1)
        {
            Cliente c = agendamento1.Cliente;

            return $"cliente_nome={c.Nome};cliente_cpf={c.Cpf};cliente_email={c.Email};cliente_telefone={c.Telefone}";
        }
    }
}