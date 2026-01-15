using System.ComponentModel.DataAnnotations.Schema;

namespace Smulasya2.Areas.Admin.ViewModel.Home
{
    public class CreateVM
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
