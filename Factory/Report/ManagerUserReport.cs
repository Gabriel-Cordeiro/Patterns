namespace FactoryAndStrategy.Report
{
    public class ManagerUserReport : UserReport
    {
        public ManagerUserReport() : base(ReportType.Manager)
        { }
        private ManagerUserReport(int id, string nome, string email, string cpf, string senha) : base(ReportType.Manager)
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

        public override UserReport GetReport(User user)
        {
            return new ManagerUserReport(user.Id, user.Nome, user.Email, user.Cpf, user.Senha);
       }
    }
}
