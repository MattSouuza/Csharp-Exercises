using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args) {
            System.Console.WriteLine("ByteBank - Cadastro de Clientes");
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome,cpf,email);
            
            bool trocouSenha = false;
            do {
                System.Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.trocaSenha(senha);
                
                if (trocouSenha) {
                    System.Console.WriteLine("Senha alterada com sucesso");
                } else {
                    System.Console.WriteLine("Valor inválido para uma senha");
                }
                
            int saldo = 0;
            System.Console.WriteLine($"Saldo atual {saldo}");

            } while (!trocouSenha);

        }
    }
}
