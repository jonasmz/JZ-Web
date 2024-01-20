using JZ_Web.SharedKernel.Contracts;

namespace JZPortfolio.Common.POCOEntities
{
    public class Tag : IBaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}