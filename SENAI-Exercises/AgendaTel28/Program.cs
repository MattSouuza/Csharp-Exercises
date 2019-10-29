using System;

namespace AgendaTel28
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quersair = false;
            do{

                System.Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Digite o telefone: ");
                string telefone = Console.ReadLine();
                System.Console.Write("Digite o aniversário: ");
                string aniversario = Console.ReadLine();
                
                Registro registro1 = new Registro(nome,telefone,aniversario);

                bool opcaoCorreta = false;
                do
                {
                    System.Console.Write("Deseja sair?  ");
                    System.Console.WriteLine("  Sim ou Não?");
                    string opcaoSair = Console.ReadLine().ToLower();

                    if(opcaoSair == "sim")
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("Saindo...");
                        opcaoCorreta = true;
                        quersair = true;
                    } else if(opcaoSair == "não"){
                        System.Console.WriteLine();
                        System.Console.WriteLine("Continuando...");
                        opcaoCorreta = true;
                        quersair = false;
                    } else {
                        System.Console.WriteLine("Opção inválida, tente novamente");
                        System.Console.WriteLine();
                        opcaoCorreta = false;
                    }
                } while(!opcaoCorreta);

            } while(!quersair);
        }
    }
}
