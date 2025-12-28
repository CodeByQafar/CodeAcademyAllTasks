using AdminPanel.Models.Base;

namespace AdminPanel.Models
{
    public class ProductImage:BaseEntitiy
    {
        public string ImageUrl { get; set; }
        public bool? isPrimary { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
