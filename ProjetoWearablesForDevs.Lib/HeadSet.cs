namespace ProjetoWearablesForDevs.Lib
{
    public class HeadSet : Produto
    {
        private bool Surround { get; set; }
        public HeadSet(string nome, string marca, string descricao, bool semFio, double valor, int estoque, bool surround) : base(nome, marca, descricao, semFio, valor, estoque)
        {
            SetSurround(surround);
        }
        public bool GetSurround()
        {
            return Surround;
        }
        public void SetSurround(bool surround)
        {
            Surround = surround;
        }
    }
}