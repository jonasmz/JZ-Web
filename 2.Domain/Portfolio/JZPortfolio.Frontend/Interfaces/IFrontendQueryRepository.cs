using JZPortfolio.Common.DTOs;
using JZPortfolio.Common.Interfaces;

namespace JZPortfolio.Frontend.Interfaces
{
    public interface IFrontendQueryRepository : IBasePortfolioQueryRepository<WorkResponseDTO, string>
    {
        
        Task<List<WorkResponseDTO>> GetFromTop(int quantity);
    }
}