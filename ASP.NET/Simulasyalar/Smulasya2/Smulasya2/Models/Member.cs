using Smulasya2.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smulasya2.Models
{
    public class Member : BaseEntitiy
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
