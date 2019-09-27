using System;

namespace McB_Cliente
{
    public class Cliente
    {
        //Properties 

        public string Nome; //Nome do cliente
        public string Endereco; //Endereço " "
        public string Telefone; //Telefone " "
        public string Senha; // Senha de acesso do cliente ao sistema
        public string Email; // Email do cliente e nome de usuário do sistema
        public DateTime DataNascimento; // Data de nascimento do cliente

        //Constructor

        public Cliente(string Nome, string Telefone, string Email){
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }
    }
}