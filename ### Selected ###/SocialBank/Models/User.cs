using System;

namespace SocialBank.Models
{
    public class User
    {
        public string csu {get;set;}
        public string nome {get;set;}
        public DateTime dataNasc {get;set;}
        public string genero {get;set;}
        public string email {get;set;}
        public string senha {get;set;}

        public User (string email, string nome, string csu, DateTime dataNasc, string genero)
        {
            this.nome = nome;
            this.csu = csu;
            this.dataNasc = dataNasc;
            this.genero = genero;
            this.email = email;
        }

        //TODO: Criar outro construtor para o userLogin aqui

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
