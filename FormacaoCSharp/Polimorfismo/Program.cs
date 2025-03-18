using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Aluno a1 = new Aluno();

            a1.Nome = "Luís";
            a1.Idade = 32;
            a1.Nota = 10;
            a1.Apresentar();


            Professor p1 = new Professor();

            p1.Nome = "Fernando";
            p1.Idade = 32;
            p1.Salario = 5000.00;
            p1.Apresentar();
            







        }
    }


    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Inserindo a palavra chave virtual para permitir que o método da classe filha possa ser sobescrito
        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }

    class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}.");
        }

    }

    class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou professor e ganho  {Salario.ToString("C")}.");

        }
    }
}
