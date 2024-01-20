namespace JZPortfolio.Common.Interfaces
{
    public interface IBasePortfolioQueryRepository<TResponse, TId>
    {
        TResponse GetById(TId id);
    }
}