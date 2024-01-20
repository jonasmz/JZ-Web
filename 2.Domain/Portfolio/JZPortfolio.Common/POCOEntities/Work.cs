using JZ_Web.SharedKernel.Contracts;

namespace JZPortfolio.Common.POCOEntities
{
    public class Work : IBaseEntity<string>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LinkToGitRepo { get; set; }
        public bool Enabled { get; set; }
    }
}