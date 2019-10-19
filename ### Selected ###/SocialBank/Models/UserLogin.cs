using System;

namespace SocialBank.Models
{
    public class UserLogin
    {
        string email {get;set;}
        string senha {get;set;}

        public UserLogin(string email)
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
                return false;
            }
        }
    }
}