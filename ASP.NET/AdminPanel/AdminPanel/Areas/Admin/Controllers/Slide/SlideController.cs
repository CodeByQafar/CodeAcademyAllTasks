using AdminPanel.Areas.Admin.ViewModels.Slide;
using AdminPanel.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace AdminPanel.Areas.Admin.Controllers.Slide
{
    [Area("Admin")]
    public class SlideController : Controller
    {
        private readonly AppDbContext _context;

        public SlideController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> slide = await _context.Sliders.ToListAsync();
            SlideVM slideVM = new SlideVM
            {
                Sliders = slide
            };
            return View(slideVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id < 1 || id == null)
            {
                return RedirectToAction("Index", "Error", new { area = "Admin", message = "Id can't be empty or negative number" });
            }
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider is null)
            {
                return RedirectToAction("Index", "Error", new { area = "Admin", message = "This slider is not exist" });
            }
            return View(slider);
        }
        public IActionResult Delete()
        {
            return View();
        }

    }
}
