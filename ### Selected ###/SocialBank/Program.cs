using System;

namespace SocialBank.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userNaoSaiu = true;

            do {
                #region Menu Screen

                System.Console.WriteLine("=========================|||=========================");
                System.Console.WriteLine("   Bem-vindo ao Fundo Social do Labor - SocialBank");
                System.Console.WriteLine("=========================|||=========================");
                System.Console.WriteLine();
                System.Console.WriteLine("      República Federativa Socialista do Brasil      ");
                System.Console.WriteLine();

                System.Console.WriteLine("SocialBnk - Escolha uma opção: ");
                System.Console.WriteLine("1 - Entrar na sua Conta");
                System.Console.WriteLine("2 - Cadastrar uma nova Conta");
                System.Console.WriteLine("3 - Sair");

                string opcaoUser = Console.ReadLine();
                
                #endregion

                #region Options

                switch (opcaoUser)
                {
                    case "1":
                        #region Login

                        System.Console.WriteLine("SocialBank - Faça Login");
                        System.Console.WriteLine();
                        System.Console.WriteLine("Email: ");
                        string email = Console.ReadLine();
                        System.Console.WriteLine();
                        
                        UserLogin userLogin1 = new UserLogin(email);

                        bool inserirSenha = false;
                        do
                        {
                            System.Console.WriteLine("Senha: ");
                            string senha = Console.ReadLine();
                            inserirSenha = userLogin1.InserirSenha(senha);
                        }
                        while (!inserirSenha);
                    
                        #endregion

                        #region Login da Conta

                        System.Console.WriteLine("SocialBank - Login da Conta");
            
                        System.Console.Write("Entre com a agência: ");
                        int agencia = int.Parse(Console.ReadLine());
                        System.Console.WriteLine();

                        System.Console.Write("Entre com a conta: ");
                        int conta = int.Parse(Console.ReadLine());
                        System.Console.WriteLine();
                        
                        ContaSocial contaSocailLogin1 = new ContaSocial(agencia, conta, userLogin1);

                        #endregion
                    break;

                    case "2":
                        #region Cadastro
                    

                        #endregion
                    break;

                    case "3":
                        #region Sair

                        userNaoSaiu = false;
                        System.Console.WriteLine("Saindo do SocialBank ...");
                        
                        #endregion
                    break;

                    default:
                    System.Console.WriteLine("Opção inválida, por favor tente novamente.");
                    break;
                }

                #endregion
            } while (userNaoSaiu);
        }
    }
}
