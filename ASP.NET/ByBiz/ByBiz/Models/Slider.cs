using ByBiz.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ByBiz.Models
{
    public class Slider: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
