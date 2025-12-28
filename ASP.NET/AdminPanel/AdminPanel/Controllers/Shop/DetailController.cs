using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers.Detail
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
