using System;

namespace ByteBank
{
    public class Cliente
    {
        public string cpf {get;set;}
        public string nome {get;set;}
        public string email {get;set;}
        public string senha {get;set;}

        public Cliente (string nome, string cpf, string email) {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
        }

        public bool trocaSenha (string senha) {
            if ((senha.Length > 6) && (senha.Length < 16)) {
                this.senha = senha;
                return true;
            } else {
                return false;
            }
        }
    }
}