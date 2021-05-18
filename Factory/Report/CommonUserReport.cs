namespace FactoryAndStrategy.Report
{
    public class CommonUserReport : UserReport
    {
        public CommonUserReport() : base(ReportType.Common)
        { }

        private CommonUserReport(int id, string nome, string email) : base(ReportType.Common)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public override UserReport GetReport(User user)
        {
            return new CommonUserReport(user.Id, user.Nome, user.Email);
        }
    }
}
