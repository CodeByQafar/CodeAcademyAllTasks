using AdminPanel.DAL;
using AdminPanel.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
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


        public IActionResult Index()
        {
            List<Slider> sliders=_context.Sliders.ToList();
  
            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders.OrderBy(e => e.Order).ToList()
            };

         
            return View(homeVM);
        }


      
    }
}
