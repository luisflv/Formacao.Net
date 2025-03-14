using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int Id, string Nome, string Sobrenome) tupla = (1, "Luís", "Varela");

            Console.WriteLine($"Id: {tupla.Id}");
            Console.WriteLine($"Nome: {tupla.Nome}");
            Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");

            Console.WriteLine("--------------------------");
            LeituraArquivo arquivo = new LeituraArquivo();

            var (sucesso, linhasArquivos, quantidadeLinhas) = arquivo.LerArquivo(@"C:\Users\Luís Fernando\Downloads\Teste.txt");
        
            if (sucesso)
            {
                foreach (var linhas in linhasArquivos)
                {
                    Console.WriteLine(linhas.ToString());
                }

                Console.WriteLine(quantidadeLinhas);
            }
            else
            {
                Console.WriteLine("Não foi possível ler o arquivo!");
            }
        
        
        }
    }

    class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception) 
            { 
                return (false,new  string[0], 0);
            }
        }
    }

}
