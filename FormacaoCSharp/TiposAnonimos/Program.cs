using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var valores = new { Nome = "Luís", Sobrenome = "Varela", Altura = 1.70 };


            Console.WriteLine("Nome: " + valores.Nome );
            Console.WriteLine("Sobrenome: " + valores.Sobrenome);
            Console.WriteLine("Altura: " + valores.Altura);

        }
    }
}
