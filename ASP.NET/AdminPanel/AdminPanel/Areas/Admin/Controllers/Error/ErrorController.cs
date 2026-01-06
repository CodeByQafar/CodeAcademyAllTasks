using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Areas.Admin.Controllers.Error
{
    [Area("Admin")]
    public class ErrorController : Controller
    {
        public IActionResult Index(string errorMesage)
        {
            return View(model:errorMesage);
        }
    }
}
