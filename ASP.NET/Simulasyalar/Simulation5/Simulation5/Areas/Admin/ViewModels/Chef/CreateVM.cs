using Microsoft.AspNetCore.Mvc.Rendering;
using Simulation5.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simulation5.Areas.Admin.ViewModels.Chefs
{
    public class CreateVM
    {

       
        public string FullName { get; set; }
        public int PositionId { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile imageFile { get; set; }
        public List<Position>? Positions { get; set; }
    }
}
