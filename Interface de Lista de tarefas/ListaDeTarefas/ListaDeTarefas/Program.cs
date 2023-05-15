using System;
using System.Collections.Generic;

namespace ListaDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeAfazeres tarefas = new ListaDeAfazeres();
            Console.WriteLine("Bem vindo à lista de tarefas. Você deseja:");
            Console.WriteLine("1: Verificar a lista");
            Console.WriteLine("2: Adicionar uma tarefa");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    tarefas.MostrarTarefas();
                    break;
                case 2:
                    string tarefa = Console.ReadLine();
                    tarefa.AdicionarTarefa(tarefa);

                    break;
            }
        }
    }

    public class ListaDeAfazeres
    {
        Queue<string> Afazer;
        Stack<string> Feito;

        public void AdicionarTarefa(string tarefa)
        {
            Afazer.Enqueue(tarefa);
        }

        public void ConcluirTarefa()
        {
            string tarefa = Afazer.Dequeue();
            Feito.Push(tarefa);
        }

        public void MostrarTarefas()
        {
            Console.WriteLine("Aqui está a sua lista de tarefas atual:");
            foreach (string tarefa in Afazer)
            {
                Console.WriteLine("-"+tarefa);
            }
            Console.WriteLine("\nTarefas concluídas: ");
            foreach (string tarefa in Feito)
            {
                Console.WriteLine("-"+ tarefa);
            }
        }
    }
}
