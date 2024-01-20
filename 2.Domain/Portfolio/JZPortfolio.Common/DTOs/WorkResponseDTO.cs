using JZPortfolio.Common.POCOEntities;
using JZPortfolio.Common.ValueObjects;

namespace JZPortfolio.Common.DTOs
{
    public class WorkResponseDTO : Work
    {
        
        public List<Image> Images { get; set; }
        public List<Tag> Tags { get; set; }
    }
}