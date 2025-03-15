using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Serializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Venda v1 = new Venda(1, "Material de escritório", 25.00M);
            
            string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

            Console.WriteLine(serializado);

            File.WriteAllText(@"C:\Users\Luís Fernando\source\repos\Formacao.Net\FormacaoCSharp\Serializacao\Arquivos\vendas.json", serializado);

        }
    }


    class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }


        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;  
            Preco = preco;
        }
    }

}
