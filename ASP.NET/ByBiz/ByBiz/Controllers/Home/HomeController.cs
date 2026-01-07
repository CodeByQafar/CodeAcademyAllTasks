using ByBiz.DAL;
using ByBiz.Models;
using ByBiz.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace ByBiz.Controllers.Home
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           List<Slider> sliders=_context.Sliders.ToList();
            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,  
                //Portfolios = _context.Portfolios.ToList(),
                //Services = _context.Services.ToList(),
                //Teams = _context.Teams.ToList()
            };
            return View(homeVM);
        }
    }
}
