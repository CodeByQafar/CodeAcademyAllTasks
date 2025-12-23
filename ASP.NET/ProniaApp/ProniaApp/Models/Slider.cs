<<<<<<< HEAD
﻿namespace Test.Models
{
    public class Slider
    {
       public int Id { get; set; }
        public string UpTitle { get; set; }
        public string Title { get; set; }
        public string SupTitle { get; set; }
        public string ImagePath { get; set; }
        public int Order { get; set; }
        public bool IsDeleted { get; set; }
    
=======
﻿namespace ProniaApp.Models
{
    public class Slider:BaseEntity
    {
        public string Title { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public string Image { get; set; }
>>>>>>> e0010f2c2514cb938bbcbaabf4c64aea975c0d84
    }
}
