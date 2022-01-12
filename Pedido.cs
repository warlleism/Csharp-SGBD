using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInteSGBD
{
    public class Pedido
    {

       
        public double ValorPedido { get; set; }

        public string DescricaoDoPedido { get; set; }

        public DateTime DataEmissao { get; set; }

        public List<Produtos> Produtos { get; set; }

        public Pedido()
        {

        }

        public Pedido( string DescricaoDoPedido, DateTime DataEmissao)
        {
            this.DescricaoDoPedido = DescricaoDoPedido;
            this.DataEmissao = DataEmissao;
            this.Produtos = new List<Produtos>();
        }

        public void adicionarProdutos(Produtos produto)
        {
            this.Produtos.Add(produto);
        }

        public void CalcularTotalPedido()
        {
            foreach(Produtos itens in Produtos)
            {
                this.ValorPedido += itens.valorProduto;
            }
        }

        public double RetornarValorPedido()
        {
            return this.ValorPedido;
        }
    }
}
