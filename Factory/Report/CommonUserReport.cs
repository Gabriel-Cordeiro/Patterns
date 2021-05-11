namespace FactoryAndStrategy.Report
{
    public class CommonUserReport : UserReport
    {
        public CommonUserReport() : base(ReportType.Comum)
        { }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public override void MapUser(User user)
        {
            this.Id = user.Id;
            this.Nome = user.Nome;
            this.Email = user.Email;
        }
    }
}
