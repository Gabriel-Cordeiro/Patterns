namespace FactoryAndStrategy.Report
{
    public class ManagerUserReport : UserReport
    {
        public ManagerUserReport() : base(ReportType.Gerente)
        { }
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public string Senha { get; set; }

        public override void MapUser(User user)
        {
            this.Id = user.Id;
            this.Nome = user.Nome;
            this.Email = user.Email;
            this.Cpf = user.Cpf;
            this.Senha = user.Senha;
        }
    }
}
