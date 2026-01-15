using FitnessTemplate.DAL;
using FitnessTemplate.Models;
using FitnessTemplate.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTemplate.Controllers.Home
{
    public class HomeController : Controller
    {public readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Trainer> trainers=_context.Trainers.ToList();
            HomeVM homeVM=new HomeVM
            {
                Trainers=trainers
            };
            return View(homeVM);
        }

    }
}
