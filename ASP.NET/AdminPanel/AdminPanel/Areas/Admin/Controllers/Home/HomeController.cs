using AdminPanel.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Areas.Admin.Controllers.Home
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [Area("Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
