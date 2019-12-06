using System;

namespace RoleTopMVC.Models
{
    public class Evento 
    {
        public Cliente Cliente {get;set;}
        public string NomeEvento {get;set;}
        public string TipoEvento {get;set;}
        public string StatusEvento {get;set;}
        public string Planos {get;set;} //Subject to change
        public string  NumeroPessoas {get;set;}
        public DateTime DataEvento {get;set;}
        public string HoraInicio {get;set;}
        public string HoraTermino {get;set;}
        public string Descricao {get;set;}
        public string NomePropietario {get;set;}
        public string NumeroCartao {get;set;}
        public string Cvv {get;set;}
        public DateTime DataValidade {get;set;}

        public Evento()
        {

        }

        public Evento(string Nome, string Cpf, string Email, string Telefone)
        {
            this.Cliente = new Cliente();
            Cliente.Nome = Nome;
            Cliente.Cpf = Cpf;
            Cliente.Email = Email;
            Cliente.Telefone = Telefone;
        }

        public Evento(string nomeEvento, string tipoEvento, string planos,string statusEvento, string numeroPessoas, DateTime dataEvento, string horaInicio, string horaTermino, string descricao)
        {
            this.NomeEvento = nomeEvento;
            this.TipoEvento = tipoEvento;
            this.Planos = planos;
            this.NumeroPessoas = numeroPessoas;
            this.DataEvento = dataEvento;
            this.HoraInicio = horaInicio;
            this.HoraTermino = horaTermino;
            this.Descricao = descricao;
        }

        public Evento(string nomeProprietario, string numeroCartao, string cvv, DateTime dataValidade)
        {
            this.NomePropietario = nomeProprietario;
            this.NumeroCartao = numeroCartao;
            this.Cvv = cvv;
            this.DataValidade = dataValidade;
        }
    }
}