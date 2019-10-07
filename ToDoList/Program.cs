using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDoItem> todoList = new List<ToDoItem>();
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;

            try 
            {
                string[] todoFile =  File.ReadAllLines(filePath);

                foreach (string line in todoFile)
                {
                    string[] itens =  line.Split(",");
                    string titulo = itens[0].Replace("\"", "");
                    string nota = itens[1].Replace("\"", "");

                    ToDoItem todoItem = new ToDoItem(titulo, nota);
                    todoList.Add(todoItem);
                }
            } 
            
            catch (IOException ioe)
            {
                System.Console.WriteLine("Erro ao acessar arquivo");
                System.Console.WriteLine(ioe.Message);
            }

            int opcao;

            do
            {
                Console.Clear();
                System.Console.WriteLine("To Do List");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine();
                System.Console.WriteLine("Digite uma opção");
                System.Console.WriteLine(" 1 - Adicionar Item");
                System.Console.WriteLine(" 2 - Remover Item");
                System.Console.WriteLine(" 3 - Sair do programa");
                System.Console.WriteLine("Opção: ");
                opcao = int.Parse(Console.ReadLine());
                
                switch(opcao)
                {
                    case 1:
                        Additem(todoList);
                    break;
                    case 2:
                        RemoveItem(todoList);
                    break;

                    case 3:
                        System.Console.WriteLine("Tchau!");
                    break;

                    default:
                    System.Console.WriteLine("Opção inválida");
                    Console.ReadLine();

                    break;
                }

            } while(opcao != 3);
        }

        public static void ListaItens(List<ToDoItem> todoList)
        {
            Console.Clear();
            int count = 1;
            System.Console.WriteLine("To Do List");
            System.Console.WriteLine();
            System.Console.WriteLine($"ID{"",2} Título{"",12} Notas");
            System.Console.WriteLine();

            foreach (ToDoItem item in todoList)
            {
                System.Console.WriteLine($"{count, 3}: {item.Titulo, -15} - {item.Nota}");
                count++;
            }
        }

        public static void Additem(List<ToDoItem> todoList)
        {
            Console.Clear();
            System.Console.WriteLine("Novo Item: " );
            System.Console.WriteLine();
            System.Console.WriteLine("Título: ");
            string titulo = Console.ReadLine();
            System.Console.WriteLine("Nota: ");
            string nota = Console.ReadLine();
            ToDoItem item = new ToDoItem(titulo, nota);

            todoList.Add(item); 
        }

        public static void RemoveItem(List<ToDoItem> todoList)
        {
            int index = 0;

            do
            {
                Console.Clear();
                System.Console.WriteLine("Remove Item");
                System.Console.WriteLine();
                ListaItens(todoList);
                System.Console.WriteLine("Digite o ID ou x para terminar");
                System.Console.Write("ID: ");
                string id = Console.ReadLine();
                
                if (id.ToLower() == "x") {
                    break;
                } else {
                    index = int.Parse(id) - 1;
                }

                if ((index < 0) || (index > todoList.Count - 1)) {
                    System.Console.WriteLine("ID Inválido");
                    System.Console.WriteLine("Pressione <enter> para continuar");
                    System.Console.WriteLine();
                } else {
                    todoList.RemoveAt(index);
                }
                
            } while (true);
        }
    }
}