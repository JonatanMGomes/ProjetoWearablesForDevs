namespace ProjetoWearablesForDevs.Lib
{
    public class Teclado : Produto
    {
        private bool Mecanico { get; set; }
        public Teclado(int id, string nome, string marca, string descricao, bool semFio, double valor, int estoque, bool mecanico) : base(id, nome, marca, descricao, semFio, valor, estoque)
        {
            SetMecanico(mecanico);
        }
        public bool GetMecanico()
        {
            return Mecanico;
        }
        public void SetMecanico(bool mecanico)
        {
            Mecanico = mecanico;
        }
        public override double CalcularValor(double valorBase)
        {
            if (GetMecanico())
            {
                valorBase = valorBase + 200;
            }
            if (GetSemFio())
            {
                valorBase = valorBase + (valorBase * 0.15);
            }
            return valorBase;
        }
    }

}