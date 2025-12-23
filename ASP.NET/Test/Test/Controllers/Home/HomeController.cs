using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Slider> data = new List<Slider>
{
    new Slider
    {
        Id = 1,
        UpTitle = "YAZ KAMPANIYASI",
        Title = "Gul kolleksiyasi",
        SupTitle = "Yeni sezon guller",
        Order = 2,
        IsDeleted = false,
        ImagePath = "1-1-524x617.png"
    },
    new Slider
    {
        Id = 2,
        UpTitle = "XUSUSI TEKLIF",
        Title = "Toy gulleri",
        SupTitle = "Xususi dizayn buketler",
        Order = 1,
        IsDeleted = false,
        ImagePath = "1-2-524x617.png"
    },
    new Slider
    {
        Id = 3,
        UpTitle = "EN COX SATILAN",
        Title = "Dekorativ guller",
        SupTitle = "Ev ve ofis ucun",
        Order = 4,
        IsDeleted = false,
        ImagePath = "1-2-570x633.jpg"
    },
    new Slider
    {
        Id = 4,
        UpTitle = "YENI MEHSULLAR",
        Title = "Mini buketler",
        SupTitle = "Serfeli qiymetlerle",
        Order = 3,
        IsDeleted = false,
        ImagePath = "1-2-270x300.jpg"
    }
};
            ViewBag.SliderData = data.Take(4).OrderBy(e=> e.Order).ToList();
            return View();
        }
    }
}
