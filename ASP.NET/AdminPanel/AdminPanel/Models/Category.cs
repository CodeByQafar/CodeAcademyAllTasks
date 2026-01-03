using AdminPanel.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace AdminPanel.Models
{
    public class Category:BaseEntitiy
    {
        [MaxLength(30,ErrorMessage ="name length can't be longer than 30 characters")]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
