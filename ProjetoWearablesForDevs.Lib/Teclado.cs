namespace ProjetoWearablesForDevs.Lib
{
    public class Teclado : Produto
    {
        private bool SemFio { get; set; }
        private bool Mecanico { get; set; }
        public Teclado(string nome, string marca, string descricao, double valor, int estoque, bool semFio, bool mecanico) : base(nome, marca, descricao, valor, estoque)
        {
            SetMecanico(mecanico);
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