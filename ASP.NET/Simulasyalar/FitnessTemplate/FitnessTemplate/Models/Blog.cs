using FitnessTemplate.Models.Base;

namespace FitnessTemplate.Models
{
    public class Blog:BaseEntitiy
    {
        public string Title { get; set; }
        public string SmallTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
