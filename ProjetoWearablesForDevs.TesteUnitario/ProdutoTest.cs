using Xunit;
using ProjetoWearablesForDevs.Lib;

namespace ProjetoWearablesForDevs.TesteUnitario
{
    public class ProdutoTest
    {
        [Fact]
        public void TestandoSeProdutoSalvaIdCorretamente()
        {
            //Arrange - Preparando
            var idEsperado = 1;
            var produtoTest = new Produto(idEsperado, "produto insano", "razer", "Produto top das galaxias!", true, 500, 3);
            //Act - Agindo
            var idATestar = produtoTest.GetId();
            //Assert - 
            Assert.Equal(idEsperado, idATestar);
        }
        [Fact]
        public void TestandoSeProdutoSalvaNomeCorretamente()
        {
            //Arrange - Preparando
            var nomeEsperado = "produto insano";
            var produtoTest = new Produto(1, nomeEsperado, "razer", "Produto top das galaxias!", true, 500, 3);
            //Act - Agindo
            var nomeATestar = produtoTest.GetNome();
            //Assert - 
            Assert.Equal(nomeEsperado, nomeATestar);
        }
        [Fact]
        public void TestandoSeProdutoSalvaMarcaCorretamente()
        {
            //Arrange - Preparando
            var marcaEsperada = "razer";
            var produtoTest = new Produto(1, "produto insano", marcaEsperada, "Produto top das galaxias!", true, 500, 3);
            //Act - Agindo
            var marcaATestar = produtoTest.GetMarca();
            //Assert - 
            Assert.Equal(marcaEsperada, marcaATestar);
        }
        [Fact]
        public void TestandoSeProdutoSalvaDescricaoCorretamente()
        {
            //Arrange - Preparando
            var descricaoEsperada = "Produto top das galaxias!";
            var produtoTest = new Produto(1, "produto insano", "razer", descricaoEsperada, true, 500, 3);
            //Act - Agindo
            var descricaoATestar = produtoTest.GetDescricao();
            //Assert - 
            Assert.Equal(descricaoEsperada, descricaoATestar);
        }
        [Fact]
        public void TestandoSeProdutoSalvaSemFioCorretamente()
        {
            //Arrange - Preparando
            var semFioEsperado = true;
            var produtoTest = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", semFioEsperado, 500, 3);
            //Act - Agindo
            var semFioATestar = produtoTest.GetSemFio();
            //Assert - 
            Assert.Equal(semFioEsperado, semFioATestar);
        }
        [Fact]
        public void TestandoSeProdutoSalvaValorCorretamente()
        {
            //Arrange - Preparando
            var valorEsperado = 500;
            var produtoTest = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, valorEsperado, 3);
            //Act - Agindo
            var valorATestar = produtoTest.GetValor();
            //Assert - 
            Assert.Equal(valorEsperado, valorATestar);
        }
        [Fact]
        public void TestandoSeProdutoSalvaEstoqueCorretamente()
        {
            //Arrange - Preparando
            var estoqueEsperado = 3;
            var produtoTest = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, estoqueEsperado);
            //Act - Agindo
            var estoqueATestar = produtoTest.GetEstoque();
            //Assert - 
            Assert.Equal(estoqueEsperado, estoqueATestar);
        }
        [Fact]
        public void TestandoSeProdutoAdicionaEstoqueCorretamente()
        {
            //Arrange - Preparando
            var estoqueEsperado = 3;
            var produtoTest = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 0);
            //Act - Agindo
            produtoTest.AdicionarEstoque(3);
            var estoqueATestar = produtoTest.GetEstoque();
            //Assert - 
            Assert.Equal(estoqueEsperado, estoqueATestar);
        }
        [Fact]
        public void TestandoSeProdutoRemoveEstoqueCorretamente()
        {
            //Arrange - Preparando
            var estoqueEsperado = 1;
            var produtoTest = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 5);
            //Act - Agindo
            produtoTest.RemoverEstoque(4);
            var estoqueATestar = produtoTest.GetEstoque();
            //Assert - 
            Assert.Equal(estoqueEsperado, estoqueATestar);
        }
        [Fact]
        public void TestandoSeProdutoCalculaValorCorretamente()
        {
            //Arrange - Preparando
            var valorEsperado = 500;
            var produtoTest = new Produto(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 0);
            //Act - Agindo
            var valorATestar = produtoTest.GetValor();
            //Assert - 
            Assert.Equal(valorEsperado, valorATestar);
        }
        [Fact]
        public void TestandoSeHeadSetSalvaSurroundCorretamente()
        {
            //Arrange - Preparando
            var surroundEsperado = true;
            var produtoTest = new HeadSet(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 3, surroundEsperado);
            //Act - Agindo
            var surroundATestar = produtoTest.GetSurround();
            //Assert - 
            Assert.Equal(surroundEsperado, surroundATestar);
        }
        [Fact]
        public void TestandoSeHeadSetCalculaValorCorretamente()
        {
            //Arrange - Preparando
            var valorEsperado = 1000;
            var produtoTest = new HeadSet(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 3, true);
            //Act - Agindo
            produtoTest.SetValor(500);
            var valorATestar = produtoTest.GetValor();
            //Assert - 
            Assert.Equal(valorEsperado, valorATestar);
        }
        [Fact]
        public void TestandoSeMouseSalvaDPICorretamente()
        {
            //Arrange - Preparando
            var dpiEsperado = 2500;
            var produtoTest = new Mouse(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 3, dpiEsperado);
            //Act - Agindo
            var dpiATestar = produtoTest.GetDPI();
            //Assert - 
            Assert.Equal(dpiEsperado, dpiATestar);
        }
        [Fact]
        public void TestandoSeMouseCalculaValorCorretamente()
        {
            //Arrange - Preparando
            var valorEsperado = 632.50;
            var produtoTest = new Mouse(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 3, 2500);
            produtoTest.SetValor(500);
            //Act - Agindo
            var valorATestar = produtoTest.GetValor();
            //Assert - 
            Assert.Equal(valorEsperado, valorATestar);
        }
        [Fact]
        public void TestandoSeTecladoSalvaMecanicoCorretamente()
        {
            //Arrange - Preparando
            var mecanicoEsperado = true;
            var produtoTest = new Teclado(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 3, mecanicoEsperado);
            //Act - Agindo
            var mecanicoATestar = produtoTest.GetMecanico();
            //Assert - 
            Assert.Equal(mecanicoEsperado, mecanicoATestar);
        }
        [Fact]
        public void TestandoSeTecladoCalculaValorCorretamente()
        {
            //Arrange - Preparando
            var valorEsperado = 805;
            var produtoTest = new Teclado(1, "produto insano", "razer", "Produto top das galaxias!", true, 500, 3, true);
            produtoTest.SetValor(500);
            //Act - Agindo
            var valorATestar = produtoTest.GetValor();
            //Assert - 
            Assert.Equal(valorEsperado, valorATestar);
        }
    }
}