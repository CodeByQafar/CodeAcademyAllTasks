using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simulasya3.DAL;
using Simulasya3.Models;
using Simulasya3.ViewModels.Home;

namespace Simulasya3.Controllers.Home
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;

        }
        public async Task< IActionResult> Index()
        {
            List<Team> _teams =await _context.Teams.ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                teams = _teams
            };
            return View(homeVM);
        }
    }
}
