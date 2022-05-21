namespace ProjetoWearablesForDevs.Web.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public bool SemFio { get; set; }
        public double Valor { get; set; }
        public int Estoque { get; set; }
    }
}