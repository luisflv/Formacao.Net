using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Luís", 32);

            (string nome, int idade) = p1;

            Console.WriteLine($"{nome} {idade}");
        }
    }

    class Pessoa 
    {
        private string nome;
        private int idade;

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Deconstruct(out string nome, out int idade)
        {
            nome = Nome;
            idade = Idade;
        }

    }
}
