namespace ProjetoWearablesForDevs.Lib
{
    public class Produto
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Marca { get; set; }
        private string Descricao { get; set; }
        private bool SemFio { get; set; }
        private double Valor { get; set; }
        private int Estoque { get; set; }
        public Produto(int id, string nome, string marca, string descricao, bool semFio, double valor, int estoque)
        {
            SetId(id);
            SetNome(nome);
            SetMarca(marca);
            SetDescricao(descricao);
            SetSemFio(semFio);
            SetValor(valor);
            SetEstoque(estoque);
        }
        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public int GetEstoque()
        {
            return Estoque;
        }
        public void SetEstoque(int estoque)
        {
            Estoque = estoque;
        }
    }
}