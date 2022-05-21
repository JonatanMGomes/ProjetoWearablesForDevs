namespace ProjetoWearablesForDevs.Web.DTOs
{
    public class PedidoDTO
    {
        public ClienteDTO ClienteDTO { get; set; }
        public List<ProdutoDTO> ProdutosDTOs { get; set; }
        public double ValorTotal { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
    }
}