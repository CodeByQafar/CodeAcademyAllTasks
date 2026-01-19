using Simulasya3.Models.Base;

namespace Simulasya3.Models
{
    public class Team:BaseEntitiy
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
    }
}
