using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Corrente c = new Corrente();

            c.Creditar(500);
            c.ExibirSaldo();
        }
    }


    abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {saldo}");
        }
    }

    class Corrente : Conta

    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }


}
