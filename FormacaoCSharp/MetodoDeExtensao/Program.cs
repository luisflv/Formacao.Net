using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDeExtensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;

            bool ehPar = numero.EhPar();

            string verificaParImpar = numero + (ehPar ? " é par" : " é ímpar");

            Console.WriteLine(verificaParImpar);

        }
    }


    static class IntExtension
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}
