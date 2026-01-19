using Simulation5.Models.Base;

namespace Simulation5.Models
{
    public class Chef:BaseEntitiy
    {
        public string FullName {  get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
