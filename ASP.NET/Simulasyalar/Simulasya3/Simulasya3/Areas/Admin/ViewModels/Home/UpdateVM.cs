using System.ComponentModel.DataAnnotations.Schema;

namespace Simulasya3.Areas.Admin.ViewModels.Home
{
    public class UpdateVM
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string? ImageUrl { get; set; }
        public int Order { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
