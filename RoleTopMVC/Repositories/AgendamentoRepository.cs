using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class AgendamentoRepository : RepositoryBase
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

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var agendamentos = ObterTodos();
            List<Evento> agendamentosCliente = new List<Evento>();

            foreach (var evento in agendamentos)
            {
                if(evento.Cliente.Email.Equals(emailCliente))
                {
                    agendamentosCliente.Add(evento);
                }
            }
            return agendamentosCliente;
        }

        public List<Evento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> agendamentos = new List<Evento>();
            foreach (var linha in linhas)
            {
                Evento agendamento = new Evento();
                agendamento.Cliente = new Cliente();

                agendamento.Cliente.Nome = ExtrairValorDoCampo("nome", linha);
                agendamento.Cliente.Cpf = ExtrairValorDoCampo("cpf", linha);
                agendamento.Cliente.Email = ExtrairValorDoCampo("email", linha);
                agendamento.Cliente.Telefone = ExtrairValorDoCampo("telefone", linha);
                agendamento.NomeEvento = ExtrairValorDoCampo("evento_nome", linha);
                agendamento.TipoEvento = ExtrairValorDoCampo("evento_tipo", linha);
                agendamento.StatusEvento = ExtrairValorDoCampo("evento_status", linha);
                agendamento.Planos = ExtrairValorDoCampo("planos", linha);
                agendamento.NumeroPessoas = ExtrairValorDoCampo("numero_pessoas", linha);
                agendamento.DataEvento = DateTime.Parse(ExtrairValorDoCampo("data_evento", linha));
                agendamento.HoraInicio = ExtrairValorDoCampo("hora_inicio", linha);
                agendamento.HoraTermino = ExtrairValorDoCampo("hora_termino", linha);
                agendamento.Descricao = ExtrairValorDoCampo("descricao", linha);
                agendamento.NomePropietario = ExtrairValorDoCampo("nome_proprietario", linha);
                agendamento.NumeroCartao = ExtrairValorDoCampo("numero_cartao", linha);
                agendamento.Cvv = ExtrairValorDoCampo("cvv", linha);
                agendamento.DataValidade = DateTime.Parse(ExtrairValorDoCampo("data_validade", linha));

                agendamentos.Add(agendamento);
            }
            return agendamentos;
        }

        public string FazerRegistroCSV(Evento agendamento)
        {
            Cliente c = agendamento.Cliente;
            Evento a = agendamento;

            return $"nome={c.Nome};cpf={c.Cpf};email={c.Email};telefone={c.Telefone};evento_nome={a.NomeEvento};evento_tipo={a.TipoEvento};evento_status={a.StatusEvento};planos={a.Planos};numero_pessoas={a.NumeroPessoas};data_evento={a.DataEvento};hora_inicio={a.HoraInicio};hora_termino={a.HoraTermino};descricao={a.Descricao};nome_proprietario={a.NomePropietario};numero_cartao={a.NumeroCartao};cvv={a.Cvv};data_validade={a.DataValidade}";
        }
    }
}