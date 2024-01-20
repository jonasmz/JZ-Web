using JZPortfolio.Common.DTOs;
using JZPortfolio.Frontend.Interfaces;

namespace JZPortfolio.Frontend.Services
{
    public class WorkService
    {
        private readonly IFrontendQueryRepository _repository;

        public WorkService(IFrontendQueryRepository repository)
        {
            _repository = repository;
        }

        public async Task<WorkResponseDTO> GetById(string id){
            var result = await _repository.GetById(id);
            return result;
        }

        public async Task<List<WorkResponseDTO>> GetFromTop(int quantity){
            var result = await _repository.GetFromTop(quantity);
            return result;
        }
    }
}