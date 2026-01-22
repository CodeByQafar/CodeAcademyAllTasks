using Microsoft.AspNetCore.Mvc;
using Simulation6.DAL;
using Simulation6.Models;
using Simulation6.ViewModels.HomeVM;

namespace Simulation6.Controllers.Home
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
            List<Project> projects = _context.Projects.ToList();
            HomeVM homeVM = new HomeVM
            {
                Projects = projects
            };
            return View(homeVM);
        }
    }
}
