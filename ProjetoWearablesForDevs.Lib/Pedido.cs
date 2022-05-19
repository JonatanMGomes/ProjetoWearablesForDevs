namespace ProjetoWearablesForDevs.Lib
{
    public class Pedido
    {
        private Usuario Usuario { get; set; }
        private List<Produto> Produtos { get; set; }
        private double ValorTotal { get; set; }
        private string Status { get; set; }
        private DateTime Data { get; set; }
    }
}