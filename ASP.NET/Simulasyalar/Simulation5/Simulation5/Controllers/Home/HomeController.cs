using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simulation5.DAL;
using Simulation5.Models;
using Simulation5.ViewModels.Home;
using HomeVM = Simulation5.ViewModels.Home.HomeVM;

namespace Simulation5.Controllers.Home
{
    public class HomeController : Controller
    {
        public readonly AppDBContext _context;
        public HomeController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Chef> chefs =await _context.chefs.Include(p => p.Position).ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                chefs = chefs
            };
            return View(homeVM);
        }
    }
}
