using System;

namespace McB_Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("José","55 55 5555-5555","ze@email.com");

            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone: " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);
        }
    }
}
