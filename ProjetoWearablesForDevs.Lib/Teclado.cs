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
    }

}