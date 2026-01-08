using Microsoft.AspNetCore.Mvc;

namespace ByBiz.Areas.Admin.Controllers.Team
{
   [ Area("Admin")]
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
