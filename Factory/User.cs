
namespace FactoryAndStrategy
{
    public class User
    {
        public User(int id, string nome, string email, string cpf, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Senha = senha;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public string Senha { get; set; }

    }
}
