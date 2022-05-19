namespace ProjetoWearablesForDevs.Lib
{
    public class HeadSet : Produto
    {
        private bool SemFio { get; set; }
        private bool Surround { get; set; }
        public HeadSet(string nome, string marca, string descricao, double valor, int estoque, bool semFio, bool surround) : base(nome, marca, descricao, valor, estoque)
        {
            SetSurround(surround);
            SetSemFio(semFio);
        }
        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
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