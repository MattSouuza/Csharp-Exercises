using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string loginAdm = "admin";
            string passwordAdm = "admin";

            Console.Write("Digite o seu usuário: ");
            string login = Console.ReadLine();
            Console.Write("Insira sua senha: ");
            string password = Console.ReadLine(); 

            if ((login == loginAdm) && password == passwordAdm){
                Console.WriteLine("Bem-vindo Admin. ");
            } 
            else {
                Console.Write("Bem-vindo ");
                Console.Write(login);
            }
        }
    }
}
