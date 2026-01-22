namespace Simulation6.Areas.Admin.ViewModels.Home
{
    public class CreateVM
    {
        public string Title { get; set; }
        public string ProjectType { get; set; }
        public string? ImageUrl { get; set; }

        public IFormFile imageFile { get; set; }

    }
}
