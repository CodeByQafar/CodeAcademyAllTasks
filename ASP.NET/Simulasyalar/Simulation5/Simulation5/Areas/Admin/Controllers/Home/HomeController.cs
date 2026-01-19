using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simulation5.Areas.Admin.ViewModels.Homes;
using Simulation5.DAL;
using Simulation5.Models;

namespace Simulation5.Areas.Admin.Controllers.Home
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public readonly AppDBContext _context;
        public HomeController(AppDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Chef> chefs = await _context.chefs.Include(p => p.Position).ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                chefs = chefs
            };
            return View(homeVM);
        }


    }
}
