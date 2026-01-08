using Microsoft.AspNetCore.Mvc;

namespace ByBiz.Areas.Admin.Controllers.Service
{
   [ Area("Admin")]
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
