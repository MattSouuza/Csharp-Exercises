using System;

namespace McBonaldsMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataNascismento {get;set;}

        public Cliente()
        {
            
        }

        public Cliente(string nome, string endereco, string telefone, string senha, string email, DateTime dataNascismento)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Email = email;
            this.DataNascismento = dataNascismento;
        }
    }
}