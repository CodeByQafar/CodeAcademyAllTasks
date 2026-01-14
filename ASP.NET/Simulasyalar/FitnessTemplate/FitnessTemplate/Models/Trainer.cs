using FitnessTemplate.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTemplate.Models
{
    public class Trainer : BaseEntitiy
    {
        [MaxLength(30,ErrorMessage ="Name length can't be Longer than 30 chat=racter")]
        [MinLength(3,ErrorMessage = "Name length can't be shorter than 3 chat=racter")]
        public string FullName { get; set; }
        [MaxLength(255, ErrorMessage = "Description length can't be Longer than 255 chat=racter")]
        [MinLength(1, ErrorMessage = "Description length can't be shorter than 1 chat=racter")]
        public string Description { get; set; }
        [MaxLength(30, ErrorMessage = "Position length can't be Longer than 30 chat=racter")]
        [MinLength(3, ErrorMessage = "Position length can't be shorter than 3 chat=racter")]
        public string Position { get; set; }

        public int Order { get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
