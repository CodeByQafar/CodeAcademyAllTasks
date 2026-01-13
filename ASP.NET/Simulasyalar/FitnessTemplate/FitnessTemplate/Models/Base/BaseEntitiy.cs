namespace FitnessTemplate.Models.Base
{
    public class BaseEntitiy
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
