namespace ProjetoWearablesForDevs.Lib
{
    public class Usuario
    {
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }
        public Usuario(string nome, string email, string senha)
        {
            SetNome(nome);
            SetEmail(email);
            SetSenha(senha);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetSenha()
        {
            return Senha;
        }
        public void SetSenha(string senha)
        {
            Senha = senha;
        }
    }
}