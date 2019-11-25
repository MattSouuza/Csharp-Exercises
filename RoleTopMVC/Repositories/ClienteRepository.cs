using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] {FazerRegistroCSV(cliente)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        private string FazerRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome};cpf={cliente.Cpf};email={cliente.Email};senha={cliente.Senha};telefone={cliente.Telefone}";
        }
    }
}