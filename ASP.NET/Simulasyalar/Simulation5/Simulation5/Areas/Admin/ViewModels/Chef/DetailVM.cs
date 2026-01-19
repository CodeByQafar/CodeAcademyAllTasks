using Simulation5.Models;

namespace Simulation5.Areas.Admin.ViewModels.Chefs
{
    public class DetailVM
    {
        public string FullName { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
