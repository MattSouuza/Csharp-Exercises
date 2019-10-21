using System;

namespace SocialBank.Models
{
    public class User
    {
        public string cpf {get;set;}
        public string nome {get;set;}
        public string dataNasc {get;set;}
        public string genero {get;set;}
        public string email {get;set;}
        public string senha {get;set;}

        public User(string email, string nome, string cpf, string dataNasc, string genero)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNasc = dataNasc;
            this.genero = genero;
            this.email = email;
        }

        public User(string email)
        {
            this.email = email;
        } 

        public bool InserirSenha(string senha)
        {
            if((senha.Length >= 6) && (senha.Length <= 16))
            {
                this.senha = senha;
                return true;
            } else {
                System.Console.WriteLine("Senha Inválida");
                return false;
            }
        }

        public bool DefinirSenha(string senha)
        {
            if((senha.Length >= 6) && (senha.Length <= 16))
            {
                this.senha = senha;
                return true;
            } else {
                return false;
            }
        }
    }
}
