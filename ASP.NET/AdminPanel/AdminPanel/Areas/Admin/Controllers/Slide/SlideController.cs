using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Areas.Admin.Controllers.Slide
{
    public class SlideController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete() {
            return View();
        }
     
    }
}
