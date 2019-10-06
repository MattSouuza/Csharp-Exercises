using System;

namespace SocialBank
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userNaoSaiu = true;
            
            do {
                #region Menu Screen

                System.Console.WriteLine("=========================|☭|=========================");
                System.Console.WriteLine("  Bem-vindo ao Fundo Social do Labor - SocialBank");
                System.Console.WriteLine("=========================|☭|=========================");
                System.Console.WriteLine();
                System.Console.WriteLine("Aqui você pode retirar o seus Vouchers de Trabalho");
                System.Console.WriteLine();

                System.Console.WriteLine("Escolha uma opção: ");
                System.Console.WriteLine(" 1 - Entrar na sua Conta");
                System.Console.WriteLine(" 2 - Cadastrar uma nova Conta");
                System.Console.WriteLine(" 3 - Sair");

                string opcaoUser = Console.ReadLine();
                
                #endregion

                #region Options

                switch (opcaoUser)
                {
                    case "1":
                    string senhaLocal = User(email, senha);
                    break;

                    case "3":
                    userNaoSaiu = false;
                    System.Console.WriteLine("Saindo do SocialBank ...");
                    break;

                    default:
                    System.Console.WriteLine("Opção inválida, por favor tente de novo.");
                    break;
                }

                #endregion
            } while (userNaoSaiu);
        }
    }
}
