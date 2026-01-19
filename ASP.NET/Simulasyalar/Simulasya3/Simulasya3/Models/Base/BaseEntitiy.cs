namespace Simulasya3.Models.Base
{
    public class BaseEntitiy
    {
        public int Id { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
