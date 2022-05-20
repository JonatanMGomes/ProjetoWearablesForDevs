namespace ProjetoWearablesForDevs.Lib
{
    public class Pedido
    {
        private Cliente Cliente { get; set; }
        private List<Produto> Produtos { get; set; }
        private double ValorTotal { get; set; }
        private string Status { get; set; }
        private DateTime Data { get; set; }
        public Pedido(Cliente Cliente, string Status, string Data)
        {
            SetCliente(Cliente);
            SetStatus(Status);
            SetData(Data);
            Produtos = new List<Produto>();
        }
        public Cliente GetCliente()
        {
            return Cliente;
        }
        public void SetCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
        public List<Produto> GetProdutos()
        {
            return Produtos;
        }
        public void SetProdutos(List<Produto> lista)
        {
            Produtos = lista;
        }
        public double GetValorTotal()
        {
            return ValorTotal;
        }
        public void SetValorTotal(double valorTotal)
        {
            ValorTotal = valorTotal;
        }
        public string GetStatus()
        {
            return Status;
        }
        public void SetStatus(string status)
        {
            Status = status;
        }
        public DateTime GetData()
        {
            return Data;
        }
        public void SetData(string data)
        {
            Data = DateTime.Parse(data);
        }
        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
        public void RemoverProduto(int idProduto)
        {
            Produtos.RemoveAll(produtoARemover => produtoARemover.GetId() == idProduto);
        }
        public double FinalizarPedido()
        {
            double valorTotalARetornar = 0;
            for (int contador = 0; contador < Produtos.Count; contador++)
            {
                valorTotalARetornar = valorTotalARetornar + Produtos[contador].GetValor();
            }
            return valorTotalARetornar;
        }
    }
}