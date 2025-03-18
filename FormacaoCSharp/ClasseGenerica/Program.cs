using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseGenerica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuArray<int> arrayInteiro = new MeuArray<int>();

            arrayInteiro.AdicionarElementoArray(30);
            Console.WriteLine(arrayInteiro[0]);

            MeuArray<string> arrayString = new MeuArray<string>();

            arrayString.AdicionarElementoArray("Texto");
            Console.WriteLine(arrayString[0]);

            
        }
    }

    class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElementoArray(T elemento)
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }

        }
    }
}
