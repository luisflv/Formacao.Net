using System;
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
            string[] vetNomes = { "Cristina", "Luís", "Lucas" };


        }

        static void ListaList()
        {
            Console.WriteLine("LISTA - LIST");
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

            foreach (string item in nomes)
            {
                Console.WriteLine($"Nome: {item}");
            }
        }

        private static void FilaQueue()
        {

        }

        static void PilhaStack()
        {
            Console.WriteLine("PILHA - STACK");
            Stack<string> pilhaNomes = new Stack<string>();

            pilhaNomes.Push("Flamengo");
            pilhaNomes.Push("Inter de Lages");
            pilhaNomes.Push("Palmeiras");

            foreach(string item in pilhaNomes)
            {
                Console.WriteLine($"Nome: {item}");
            }

            Console.WriteLine("Removendo o último elemento da pilha...");
            pilhaNomes.Pop();

            foreach (string item in pilhaNomes)
            {
                Console.WriteLine($"Nome: {item}");
            }

        }

        static void DicionarioDictionary()
        {
            Console.WriteLine("DICIONÁRIO - DICTIONARY");

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("SC", "Santa Catarina");
            dic.Add("RS", "Rio Grande do Sul");

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            }

            Console.WriteLine("Removendo a chave RS...");

            dic.Remove("RS");

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            }
        }
    }
}
