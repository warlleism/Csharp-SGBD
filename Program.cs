using System;

namespace CsharpInteSGBD
{
    class Startup
    {
        static void Main(string[] args)
        {
            var produto = new Produtos("Hamburguer", 15);

            var pedido = new Pedido("Produtos Variados", DateTime.Now);

            pedido.adicionarProdutos(produto);


            pedido.CalcularTotalPedido();

            Cadastro cadastro = new Cadastro( pedido.DescricaoDoPedido, pedido.ValorPedido);

            
        }
    }
}
