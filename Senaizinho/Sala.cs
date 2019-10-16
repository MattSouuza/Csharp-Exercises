using System;

namespace Senaizinho
{
    public class Sala{
        public int capacidadeAtual;
        public int capacidadeTotal;
        public int numeroSala;
        public string[] Alunos = new string[10];
        
        public Sala(int numeroSala, int capacidadeTotal){
            this.numeroSala = numeroSala;
            this.capacidadeTotal = capacidadeTotal;
        }

        public string AlocarAlunos(string nomeAluno){
            Console.Clear();
            System.Console.WriteLine("Digite o nome do Aluno: ");
            System.Console.WriteLine();
            
            Aluno aluno = new Aluno();
            aluno.nome = Console.ReadLine();
            

            return numeroAluno;
        }

        public string RemoverAluno(string nomeAluno){

        }

        public string MostrarAlunos(){

        }
    }
}
