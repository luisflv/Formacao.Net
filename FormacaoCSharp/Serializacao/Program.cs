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

            string caminhoDoArquivo = @"C:\Users\Luís Fernando\source\repos\Formacao.Net\FormacaoCSharp\Serializacao\Arquivos\vendas.json";

            string conteudoArquivo = File.ReadAllText(caminhoDoArquivo);

            List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

            foreach (var item in listaVendas)
            {
                Console.WriteLine($"{item.Id} {item.Produto} {item.Preco} {item.DataVenda.ToString("dd/MM/yyy")}");
            }

            #region
            //DateTime dataAtual = DateTime.Now;

            //Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual );
            //Venda v2 = new Venda(2, "Material de informática", 450.00M, dataAtual);

            //List<Venda> listaVendas = new List<Venda>();

            //listaVendas.Add(v1);
            //listaVendas.Add(v2);

            //string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

            //Console.WriteLine(serializado);

            //string caminhoDoArquivo = @"C:\Users\Luís Fernando\source\repos\Formacao.Net\FormacaoCSharp\Serializacao\Arquivos\vendas.json";

            ////Escrevendo o objeto serializado em um arquivo com extensão .JSON
            //File.WriteAllText(caminhoDoArquivo, serializado);
            #endregion
        }
    }


    class Venda
    {

        [JsonProperty("id_prod")]
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }

        public DateTime DataVenda { get; set; }
    }

    //class Venda
    //{
    //    public int Id { get; set; }
    //    public string Produto { get; set; }
    //    public decimal Preco { get; set; }

    //    public DateTime DataVenda { get; set; }


    //    public Venda(int id, string produto, decimal preco, DateTime dataVenda)
    //    {
    //        Id = id;
    //        Produto = produto;  
    //        Preco = preco;
    //        DataVenda = dataVenda;
    //    }
    //}

}
