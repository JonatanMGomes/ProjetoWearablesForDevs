namespace ProjetoWearablesForDevs.Lib
{
    public class Mouse : Produto
    {
        private int DPI { get; set; }
        public Mouse(int id, string nome, string marca, string descricao, bool semFio, double valor, int estoque, int dpi) : base(id, nome, marca, descricao, semFio, valor, estoque)
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
        public override double CalcularValor(double valorBase)
        {
            valorBase = valorBase + (DPI / 50);
            if (GetSemFio())
            {
                valorBase = valorBase + (valorBase * 0.15);
            }
            return valorBase;
        }
    }
}