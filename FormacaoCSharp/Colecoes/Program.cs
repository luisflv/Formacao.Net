﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VetorArray();
            ListaList();
            FilaQueue();
            PilhaStack();
            DicionarioDictionary();
        }

        static void VetorArray()
        {
            Console.WriteLine("============================");
            Console.WriteLine("|        VETOR - ARRAY     |");
            Console.WriteLine("============================");

            string[] vetNomes = { "Cristina", "Luís", "Lucas" };

            foreach (var item in vetNomes)
            {
                Console.WriteLine($"Nome: {item}");
            }

        }

        static void ListaList()
        {
            Console.WriteLine("============================");
            Console.WriteLine("|        LISTA - LIST      |");
            Console.WriteLine("============================");

            List<string> nomes = new List<string>();

            nomes.Add("Cristina");
            nomes.Add("Luís");
            nomes.Add("Lucas");

            foreach (string item in nomes)
            {
                Console.WriteLine($"Nome: {item}");
            }

            Console.WriteLine("Removendo o nome Luís...");
            nomes.Remove("Luís");

            Console.WriteLine("--------------------");

            foreach (string item in nomes)
            {
                Console.WriteLine($"Nome: {item}");
            }

            Console.WriteLine("***************************************");

        }

        private static void FilaQueue()
        {
            Console.WriteLine("============================");
            Console.WriteLine("|        FILA - QUEUE      |");
            Console.WriteLine("============================");

            Queue<string> filaNomes = new Queue<string>();

            filaNomes.Enqueue("Luís");

            foreach (var item in filaNomes)
            {
                Console.WriteLine($"Nomes: {item}");
            }
            Console.WriteLine("***************************************");

        }

        static void PilhaStack()
        {
            Console.WriteLine("============================");
            Console.WriteLine("|        PILHA - STACK      |");
            Console.WriteLine("============================");

            Stack<string> pilhaNomes = new Stack<string>();

            pilhaNomes.Push("Flamengo");
            pilhaNomes.Push("Inter de Lages");
            pilhaNomes.Push("Palmeiras");

            foreach (string item in pilhaNomes)
            {
                Console.WriteLine($"Nome: {item}");
            }

            Console.WriteLine("Removendo o último elemento da pilha...");
            pilhaNomes.Pop();
            Console.WriteLine("--------------------");

            foreach (string item in pilhaNomes)
            {
                Console.WriteLine($"Nome: {item}");
            }
            Console.WriteLine("***************************************");

        }

        static void DicionarioDictionary()
        {
            Console.WriteLine("--------------------");

            Console.WriteLine("DICIONÁRIO - DICTIONARY");

            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("SC", "Santa Catarina");
            estados.Add("RS", "Rio Grande do Sul");
            estados.Add("PA", "Paraná");


            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            }

            Console.WriteLine("Removendo a chave RS...");

            estados.Remove("RS");

            Console.WriteLine("--------------------");
            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            }

            Console.WriteLine("Alterando um valor por meio de uma chave: ");
            estados["PA"] = "Pará";

            Console.WriteLine("--------------------");
            foreach (KeyValuePair<string, string> item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            }

            if (estados.ContainsKey("PA"))
            {
                Console.WriteLine($"Chave encontrada! Você não pode adicionar esta chave.");
            }
            else
            {
                Console.WriteLine("Essa chave não existe! É seguro adicionar essa chave.");
            }
            Console.WriteLine("***************************************");

        }
    }
}
