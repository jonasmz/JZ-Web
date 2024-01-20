namespace JZPortfolio.Common.Interfaces
{
    public interface IBasePortfolioQueryRepository<TResponse, TId>
    {
        Task<TResponse> GetById(TId id);
    }
}