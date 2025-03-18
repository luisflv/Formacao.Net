using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            a1.Nome = "Luís";
            a1.Idade = 32;
            a1.Nota = 9.5;
            a1.Apresentar();
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }

    class Aluno : Pessoa
    {
        public double  Nota { get; set; }
    }

    class Professor : Pessoa
    {
        public decimal Salario { get; set; }
    }


}
