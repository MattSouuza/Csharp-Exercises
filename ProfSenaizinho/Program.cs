using System;

namespace ProfSenaizinho
{
    class Program
    {

        static void Main(string[] args)
        {
            int limiteAlunos = 10;
            int limiteSalas = 10;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            //bool querSair;

            System.Console.WriteLine("Bem-vindo a Escola SENAIzinho");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - Cadastrar Aluno");
            System.Console.WriteLine("2 - Cadastrar Sala");
            System.Console.WriteLine("3 - Alocar Aluno");
            System.Console.WriteLine("4 - Remover Aluno");
            System.Console.WriteLine("5 - Verificar Salas");
            System.Console.WriteLine("6 - Verificar Alunos");
            System.Console.WriteLine("0 - Sair");
        }

        public void CadastrarAluno(Aluno[] alunos, int totalAluno, int alunosCadastrados)
        {
            if(alunosCadastrados < totalAluno)
            {
                System.Console.WriteLine("Cadastro de Alunos");
                System.Console.WriteLine();
                System.Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Data de Nascimento: ");
                DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

                Aluno novoAluno = new Aluno();
                novoAluno.nome = nome;
                novoAluno.dataNasc = dtNascimento;

                int index = 0;
                foreach(Aluno aluno in alunos){
                    if(alunos == null)
                    {
                        alunos[index] = novoAluno;
                        break;
                    }
                    index++;
                }
                alunosCadastrados++;
            }
        }

        public void CadastrarSala()
        {

        }

        public void AlocarAluno()
        {

        }

        public void RemoverAluno()
        {

        }

        public void VerificarSalas()
        {

        }

        public void VerificarAlunos()
        {

        }
        }
    }