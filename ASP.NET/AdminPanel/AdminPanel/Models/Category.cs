using AdminPanel.Models.Base;

namespace AdminPanel.Models
{
    public class Category:BaseEntitiy
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
