namespace ProjetoWearablesForDevs.Lib
{
    public class Mouse : Produto
    {
        private int DPI { get; set; }
        public Mouse(string nome, string marca, string descricao, bool semFio, double valor, int estoque, int dpi) : base(nome, marca, descricao, semFio, valor, estoque)
        {
            SetDPI(dpi);
        }
        public int GetDPI()
        {
            return DPI;
        }
        public void SetDPI(int dpi)
        {
            DPI = dpi;
        }
    }
}