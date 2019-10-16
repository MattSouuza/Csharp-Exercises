using System;

namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteAlunos = 100;
            int limiteSalas = 10;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            bool querSair = false;
            

            System.Console.WriteLine("Bem-vindo a Escola SENAIzinho");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Cadastrar Aluno");
            System.Console.WriteLine("2 - Cadastrar Sala");
            System.Console.WriteLine("3 - Alocar Aluno");
            System.Console.WriteLine("4 - Remover Aluno");
            System.Console.WriteLine("5 - Verificar Salas");
            System.Console.WriteLine("6 - Verificar Alunos");
            System.Console.WriteLine("0 - Sair");

            querSair = bool.Parse(Console.ReadLine());
            
            switch (querSair)
            {
                case "1":
                    CadastrarAluno(alunos, limiteAlunos, alunosCadastrados);
                break;

                case "2":

                break;

                case "3":

                break;

                case "4":

                break;

                case "5":

                break;

                case "6":

                break;

                case "0":

                break;

                default:
            }
        }
        public static void CadastrarAluno(Aluno[] alunos, int limiteAlunos, int alunosCadastrados){
            if(limiteAlunos > alunosCadastrados){
                System.Console.WriteLine("Insira o nome do aluno: ");
                string nome = Console.ReadLine();
                
                System.Console.WriteLine("Digite a data de nascimento: ");
                DateTime dataNasc = DateTime.Parse(Console.ReadLine());
                
                //Aluno aluno = new Aluno(nome, dataNasc);
                alunos[alunosCadastrados].nome = nome;
                alunos[alunosCadastrados].dataNasc = dataNasc;
                alunosCadastrados++;
            } else {
                System.Console.WriteLine("Nao foi possivel cadastrar o aluno");
            }
        }

        public void CadastrarSala(){

        }

        public void AlocarAluno(){

        }

        public void RemoverAluno(){

        }

        public void VerificarSalas(){

        }

        public void VerificarAlunos(){

        }
    }
}
