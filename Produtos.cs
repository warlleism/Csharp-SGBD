using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInteSGBD
{
    public class Produtos
    {
        public string nomeProduto { get; set; }
        public double valorProduto { get; set; }

        public Produtos(string nomeProduto, double valorProduto)
        {
            this.nomeProduto = nomeProduto;
            this.valorProduto = valorProduto;
        }
    }
}
