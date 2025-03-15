using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero = 10;

            bool ehPar = numero % 2 == 0;

            Console.WriteLine($"O número {numero} é " +(ehPar ? "É par!" : "É ímpar"));

        }
    }
}
