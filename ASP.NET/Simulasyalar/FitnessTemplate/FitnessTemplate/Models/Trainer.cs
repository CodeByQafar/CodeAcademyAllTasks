using FitnessTemplate.Models.Base;

namespace FitnessTemplate.Models
{
    public class Trainer:BaseEntitiy
    {
        public string FullName { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
    }
}
