using Microsoft.AspNetCore.Mvc;
using ProniaApp.DAL;
using ProniaApp.Models;

namespace ProniaApp.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    Title = "Summer Sale",
                    Discount = 50,
                    Description = "Get ready for summer with our exclusive sale!",
                    Order = 1,
                    Image = "1-1-524x617.png"
                },
                new Slider
                {
                    Title = "Winter Collection",
                    Discount = 30,
                    Description = "Stay warm and stylish with our winter collection.",
                    Order = 2,
                    Image = "1-2-524x617.png"
                }

            };
            _context.Sliders.AddRange(sliders);
            _context.SaveChanges();
            return View(sliders);
        }
    }
}
