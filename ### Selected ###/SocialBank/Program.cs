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
                System.Console.WriteLine("              Bem-vindo ao SocialBank");
                System.Console.WriteLine("=========================|||=========================");
                System.Console.WriteLine();

                System.Console.WriteLine("SocialBank - Escolha uma opção: ");
                System.Console.WriteLine("1 - Entrar na sua Conta");
                System.Console.WriteLine("2 - Cadastrar uma nova Conta");
                System.Console.WriteLine("3 - Sair");

                string opcaoUser = Console.ReadLine();
                System.Console.WriteLine();
                
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
                        
                        User userLogin1 = new User(email, "Matheus Souza Silva", "500.195.164.62", "30/11/1981", "Masculino");

                        bool inserirSenha = false;
                        do
                        {
                            System.Console.WriteLine("Senha: ");
                            string senha = Console.ReadLine();
                            inserirSenha = userLogin1.InserirSenha(senha);
                            System.Console.WriteLine();
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
                        System.Console.WriteLine($"Bem-vindo {userLogin1.nome}");
                        System.Console.WriteLine();

                        ContaCorrente contaCorrenteLogin1 = new ContaCorrente(agencia, conta, userLogin1.nome);

                        #endregion

                        #region Menu Conta (Opção Login)

                        System.Console.WriteLine("SocialBnk - Escolha uma opção: ");
                        System.Console.WriteLine();
                        System.Console.WriteLine($"Usuário(a) {contaCorrenteLogin1.titular}");
                        System.Console.WriteLine();
                        System.Console.WriteLine("1 - Depósito");
                        System.Console.WriteLine("2 - Saque");
                        System.Console.WriteLine("3 - Sair");
                        System.Console.WriteLine();

                        string opcaoUserLogado = Console.ReadLine();

                        switch(opcaoUserLogado)
                        {
                            case "1":
                                #region Depósito (Opção Logado)

                                System.Console.WriteLine("SocialBank - Depósito em Conta");
                                System.Console.Write($"Agência: {contaCorrenteLogin1.agencia}   ");
                                System.Console.WriteLine($"Conta: {contaCorrenteLogin1.conta}");
                                System.Console.WriteLine();
                                System.Console.Write("Digite o valor do Depósito: R$");
                                double valor = double.Parse(Console.ReadLine());
                                contaCorrenteLogin1.Deposito(valor);
                                System.Console.WriteLine($"Novo saldo: R${contaCorrenteLogin1.saldo}");
                                System.Console.WriteLine();

                                #endregion
                            break;

                            case "2":
                            break;

                            case "3":
                            break;

                            case "4":
                            break;

                            default:
                            break;
                        }

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
