using Microsoft.AspNetCore.Mvc;
using Smulasya2.DAL;
using Smulasya2.Models;
using Smulasya2.ViewvModels.Home;

namespace Smulasya2.Controllers.Home
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;

        public HomeController(AppDbContext context) {
            _context = context;

        }
        public IActionResult Index()
        {

           List<Member> members=_context.Members.ToList();
            HomeVM homeVM = new HomeVM
            {
                Members = members
            };
            return View(homeVM);
        }
    }
}
