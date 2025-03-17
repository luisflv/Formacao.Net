using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TiposDinamicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic valor = 4;

            Console.WriteLine($"{valor.GetType()} valor: {valor}");

            valor = "Texto";

            Console.WriteLine($"{valor.GetType()} valor: {valor}");
        }
    }
}
