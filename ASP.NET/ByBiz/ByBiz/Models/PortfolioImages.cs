using ByBiz.Models.Base;

namespace ByBiz.Models
{
    public class PortfolioImages : BaseEntity
    {
        public string ImageUrl { get; set; }
        public bool? isPrimary { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
