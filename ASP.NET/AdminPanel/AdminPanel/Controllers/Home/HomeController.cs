using AdminPanel.DAL;
using AdminPanel.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Controllers.Home
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public  IActionResult Index()

        {
             //_context.Sliders.AddRangeAsync(data);
             //_context.SaveChangesAsync();

           

            HomeVM homeVM = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Products = _context.Products.Include(p=>p.ProductImages).ToList()
            };

         
            return View(homeVM);
        }



//                 List<Slider> data = new List<Slider>
//         {
//             new Slider
//             {
           
//                 UpTitle = "YAZ KAMPANIYASI",
//                 Title = "Gul kolleksiyasi",
//                 SupTitle = "Yeni sezon guller",
//                 Order = 2,
//                 IsDeleted = false,
//                 ImagePath = "1-1-524x617.png"
//             },
//             new Slider
//             {
           
//                 UpTitle = "XUSUSI TEKLIF",
//                 Title = "Toy gulleri",
//                 SupTitle = "Xususi dizayn buketler",
//                 Order = 1,
//                 IsDeleted = false,
//                 ImagePath = "1-2-524x617.png"
//             },
//             new Slider
//             {
           
//                 UpTitle = "EN COX SATILAN",
//                 Title = "Dekorativ guller",
//                 SupTitle = "Ev ve ofis ucun",
//                 Order = 4,
//                 IsDeleted = false,
//                 ImagePath = "1-2-570x633.jpg"
//             },
//             new Slider
//             {
           
//                 UpTitle = "YENI MEHSULLAR",
//                 Title = "Mini buketler",
//                 SupTitle = "Serfeli qiymetlerle",
//                 Order = 3,
//                 IsDeleted = false,
//                 ImagePath = "1-2-270x300.jpg"
//             } , new Slider
//             {
           
//                 UpTitle = "TEST MEHSULLAR",
//                 Title = "Mini buketler",
//                 SupTitle = "Serfeli qiymetlerle",
//                 Order = 1,
//                 IsDeleted = false,
//                 ImagePath = "1-2-270x300.jpg"
//             }
//         };


    }
}
