namespace Simulasya3.Areas.Admin.ViewModels.Home
{
    public class DetailVM
    {
        public int Id { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }

        public int Order { get; set; }


    }
}
