using Microsoft.AspNetCore.Mvc;

namespace ByBiz.Areas.Admin.Controllers.Slider
{
   [ Area("Admin")]
    public class SliderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
    }
}
