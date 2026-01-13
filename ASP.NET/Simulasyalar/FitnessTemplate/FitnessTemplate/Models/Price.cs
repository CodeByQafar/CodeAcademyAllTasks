using FitnessTemplate.Models.Base;
namespace FitnessTemplate.Models
{
    public class Price:BaseEntitiy
    {
        public string Title { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
    }
}
