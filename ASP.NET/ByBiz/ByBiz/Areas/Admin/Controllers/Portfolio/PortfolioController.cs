using Microsoft.AspNetCore.Mvc;

namespace ByBiz.Areas.Admin.Controllers.Portfolio
{
   [ Area("Admin")]
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
