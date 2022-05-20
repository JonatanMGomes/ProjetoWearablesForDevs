namespace ProjetoWearablesForDevs.Lib
{
    public class Cliente : Usuario
    {
        private string CPF { get; set; }
        private string Endereco { get; set; }
        public Cliente(string nome, string email, string senha, string cpf, string endereco) : base(nome, email, senha)
        {
            SetCPF(cpf);
            SetEndereco(endereco);
        }
        public string GetCPF()
        {
            return CPF;
        }
        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
    }
}