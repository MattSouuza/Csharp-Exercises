using System;
using System.Collections.Generic;

namespace _27AgendaNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,DateTime> listaNomes = new Dictionary<string, DateTime>();
            bool querSair = false;
            
            do
            {
                Console.Clear();
                
                System.Console.WriteLine();
                System.Console.WriteLine("-------Cadastro de aniversários-------");
                System.Console.WriteLine();
                System.Console.WriteLine("          Escolha uma opção:  ");
                System.Console.WriteLine();
                System.Console.WriteLine("1 - Cadastrar aniversário");
                System.Console.WriteLine("2 - Remover aniversário");
                System.Console.WriteLine("3 - Procurar uma data de aniversário específica");
                System.Console.WriteLine("4 - Listar aniversários");
                System.Console.WriteLine("0 - Sair");
                string opcao = Console.ReadLine();
                
                switch(opcao)
                {
                    case "1":
                        Cadastro(listaNomes);
                        break;

                    case "2":
                        Remove(listaNomes);
                        break;

                    case "3":
                        Procurar(listaNomes);
                        break;

                    case "4":
                        Listar(listaNomes);
                        break;

                    case "0":
                        querSair = true;
                        System.Console.WriteLine("Saindo...");
                        break;

                    default:
                        System.Console.WriteLine("Opção inválida, tente novamente...");
                        break;
                }
            } while(!querSair);
        }

        public static void Cadastro(Dictionary<string, DateTime> listaNomes)
        {    
            bool nomeExiste = false;
            string nome = "";
            do
            {
                Console.Clear();
                
                System.Console.Write("Digite o nome do aniversariante: ");
                nome = Console.ReadLine();

                if(listaNomes.ContainsKey(nome) == true)
                {
                    System.Console.WriteLine("Este nome já existe");
                    Console.ReadLine();
                    Console.Clear();
                    nomeExiste = true;
                } else {
                    nomeExiste = false;
                }
            } while(nomeExiste);

            System.Console.Write("Digite a data de aniversário: ");
            DateTime niver = Convert.ToDateTime(Console.ReadLine());
            System.Console.WriteLine();

            listaNomes.Add(nome, niver);
            System.Console.WriteLine("Cadastro realizado com sucesso!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Remove(Dictionary<string, DateTime> listaNomes)
        {
            Console.Clear();
            
            System.Console.Write("Digite o nome a ser removido: ");
            string nomeRemove = Console.ReadLine();
            System.Console.WriteLine();
            
            if(listaNomes.ContainsKey(nomeRemove) == true)
            {
                listaNomes.Remove(nomeRemove);
                System.Console.WriteLine("Este nome foi removido");
                Console.ReadLine();
                Console.Clear();
            } else {
                System.Console.WriteLine("O nome especificado não foi encontrado");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void Procurar(Dictionary<string, DateTime> listaNomes)
        {
            Console.Clear();
            
            System.Console.Write("Digite o nome do aniversariante: ");
            string nomeProcura = Console.ReadLine();
            
            if(listaNomes.ContainsKey(nomeProcura) == true)
            {
                DateTime dataListar = listaNomes[nomeProcura];
                System.Console.WriteLine("Nome: {0}     Aniversário: {1}",nomeProcura, dataListar);
                Console.ReadLine();
            } else {
                System.Console.WriteLine();
                System.Console.WriteLine("Este nome não existe");
                Console.ReadLine();
            }
        }

        public static void Listar(Dictionary<string, DateTime> listaNomes)
        {
            Console.Clear();

            System.Console.WriteLine("Os nomes cadastrados são: ");
            
            foreach(var item in listaNomes)
            {
                System.Console.Write("Nome: {0}     ", item.Key);
                System.Console.WriteLine("Aniversário: {0}", item.Value);
            }

            Console.ReadLine();
        }
    }
}