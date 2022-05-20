namespace ProjetoWearablesForDevs.Lib
{
    public class HeadSet : Produto
    {
        private bool Surround { get; set; }
        public HeadSet(int id, string nome, string marca, string descricao, bool semFio, double valor, int estoque, bool surround) : base(id, nome, marca, descricao, semFio, valor, estoque)
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
        public override double CalcularValor(double valorBase)
        {
            if (GetSemFio() && GetSurround())
            {
                return valorBase + 500;
            }
            else if (GetSemFio() || GetSurround())
            {
                return valorBase + 150;
            }
            else
            {
                return valorBase;
            }
        }
    }
}