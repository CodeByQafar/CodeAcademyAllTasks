using AdminPanel.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Slider : BaseEntitiy
    {
        [MaxLength(30, ErrorMessage = "Discount can't be longer than 30 characters")]
        public string UpTitle { get; set; }
        [MaxLength(30, ErrorMessage = "Title can't be longer than 30 characters")]
        public string Title { get; set; }
        [MaxLength(255, ErrorMessage = "Description can't be longer than 255 characters")]
        public string SupTitle { get; set; }
        public string ImagePath { get; set; }
        public int Order { get; set; }


    }
}
