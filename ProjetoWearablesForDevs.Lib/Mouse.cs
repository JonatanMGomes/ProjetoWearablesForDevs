namespace ProjetoWearablesForDevs.Lib
{
    public class Mouse : Produto
    {
        private int DPI { get; set; }
        private bool SemFio { get; set; }
        public Mouse(string nome, string marca, string descricao, double valor, int estoque, int dpi, bool semFio) : base(nome, marca, descricao, valor, estoque)
        {
            SetDPI(dpi);
            SetSemFio(semFio);
        }
        public int GetDPI()
        {
            return DPI;
        }
        public void SetDPI(int dpi)
        {
            DPI = dpi;
        }
        public bool GetSemFio()
        {
            return SemFio;
        }
        public void SetSemFio(bool semFio)
        {
            SemFio = semFio;
        }
    }
}