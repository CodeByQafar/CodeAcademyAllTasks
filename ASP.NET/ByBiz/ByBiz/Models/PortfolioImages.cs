using ByBiz.Models.Base;

namespace ByBiz.Models
{
    public class PortfolioImages:BaseEntity
    {
        public string ImageUrl { get; set; }
      bool? isPrimary { get; set; }
    }
}
