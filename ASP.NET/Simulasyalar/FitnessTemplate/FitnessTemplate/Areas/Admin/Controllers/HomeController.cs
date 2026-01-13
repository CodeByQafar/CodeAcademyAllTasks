using Microsoft.AspNetCore.Mvc;

namespace FitnessTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    
    public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
    }

}
