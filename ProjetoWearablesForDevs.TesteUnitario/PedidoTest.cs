using Xunit;
using ProjetoWearablesForDevs.Lib;
using System.Collections.Generic;
using System;

namespace ProjetoWearablesForDevs.TesteUnitario
{
    public class PedidoTest
    {
        [Fact]
        public void TestandoSePedidoSalvaClienteCorretamente()
        {
            //Arrange - Preparando
            var clienteEsperado = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", "11122233344", "Rua A");
            var pedidoTest = new Pedido(clienteEsperado, "a caminho", "19/05/2022");
            //Act - Agindo
            var clienteATestar = pedidoTest.GetCliente();
            //Assert - 
            Assert.Equal(clienteEsperado, clienteATestar);
        }
        [Fact]
        public void TestandoSePedidoSalvaProdutosCorretamente()
        {
            //Arrange - Preparando
            var produtosEsperados = new List<Produto>();
            var produto = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 3);
            produtosEsperados.Add(produto);
            var cliente = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", "11122233344", "Rua A");
            var pedidoTest = new Pedido(cliente, "a caminho", "19/05/2022");
            pedidoTest.SetProdutos(produtosEsperados);
            //Act - Agindo
            var produtosATestar = pedidoTest.GetProdutos();
            //Assert - 
            Assert.Equal(produtosEsperados, produtosATestar);
        }
        [Fact]
        public void TestandoSePedidoSalvaValorTotalCorretamente()
        {
            //Arrange - Preparando
            var valorTotalEsperado = 5000;
            var cliente = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", "11122233344", "Rua A");
            var pedidoTest = new Pedido(cliente, "a caminho", "19/05/2022");
            pedidoTest.SetValorTotal(valorTotalEsperado);
            //Act - Agindo
            var valorTotalATestar = pedidoTest.GetValorTotal();
            //Assert - 
            Assert.Equal(valorTotalEsperado, valorTotalATestar);
        }
        [Fact]
        public void TestandoSePedidoSalvaStatusCorretamente()
        {
            //Arrange - Preparando
            var statusEsperado = "a caminho";
            var cliente = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", "11122233344", "Rua A");
            var pedidoTest = new Pedido(cliente, statusEsperado, "19/05/2022");
            //Act - Agindo
            var statusATestar = pedidoTest.GetStatus();
            //Assert - 
            Assert.Equal(statusEsperado, statusATestar);
        }
        [Fact]
        public void TestandoSePedidoSalvaDataCorretamente()
        {
            //Arrange - Preparando
            var dataEsperada = "19/05/2022";
            var cliente = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", "11122233344", "Rua A");
            var pedidoTest = new Pedido(cliente, "a caminho", dataEsperada);
            //Act - Agindo
            var dataATestar = pedidoTest.GetData();
            //Assert - 
            Assert.Equal(DateTime.Parse(dataEsperada), dataATestar);
        }
        [Fact]
        public void TestandoSePedidoAdicionaProdutoCorretamente()
        {
            //Arrange - Preparando
            var produtoAdicionadoEsperado = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 0);
            var cliente = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", "11122233344", "Rua A");
            var pedidoTest = new Pedido(cliente, "a caminho", "19/05/2022");
            //Act - Agindo
            pedidoTest.AdicionarProduto(produtoAdicionadoEsperado);
            var produtoAdicionadoATestar = pedidoTest.GetProdutos().Find(produto => produto.GetId() == produtoAdicionadoEsperado.GetId());
            //Assert - 
            Assert.Equal(produtoAdicionadoEsperado, produtoAdicionadoATestar);
        }
        [Fact]
        public void TestandoSePedidoRemoveProdutoCorretamente()
        {
            //Arrange - Preparando
            var produtoARemover = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 0);
            var cliente = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", "11122233344", "Rua A");
            var pedidoTest = new Pedido(cliente, "a caminho", "19/05/2022");
            //Act - Agindo
            pedidoTest.AdicionarProduto(produtoARemover);
            pedidoTest.RemoverProduto(1);
            var pedidoRemovido = pedidoTest.GetProdutos().Exists(produto => produto.GetId() == 1);
            //Assert - 
            Assert.Equal(false, pedidoRemovido);
        }
        [Fact]
        public void TestandoSePedidoFinalizaCorretamente()
        {
            //Arrange - Preparando
            var produto = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 0);
            var produto2 = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, 700, 0);
            var cliente = new Cliente("Jonatan", "email@email.com", "senhamuitolouca", "11122233344", "Rua A");
            var pedidoTest = new Pedido(cliente, "a caminho", "19/05/2022");
            //Act - Agindo
            pedidoTest.AdicionarProduto(produto);
            pedidoTest.AdicionarProduto(produto2);
            var valorATestar = pedidoTest.FinalizarPedido();
            //Assert - 
            Assert.Equal(1200, valorATestar);
        }
    }
}