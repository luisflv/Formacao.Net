using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool? desejaReceberEmail = null;

            if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
            {
                Console.WriteLine("O usuário optou por receber e-mail!");
            }
            else
            {
                Console.WriteLine("O usuário optou por não receber e-mail!");
            }
        }
    }
}
