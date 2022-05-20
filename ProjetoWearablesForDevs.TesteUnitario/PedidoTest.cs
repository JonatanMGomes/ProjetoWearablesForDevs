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
    }
}