using AdminPanel.Areas.Admin.ViewModels.Slide;
using AdminPanel.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
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
        [HttpPost]
        public async Task<IActionResult> Create(Slider slide)
        {
            if(slide.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "Image is required");
                return View();
            }
            if (!slide.ImageFile.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("ImageFile", "File type must be image");
                return View();
            }
            if(slide.ImageFile.Length > 2*1024*1024)
            {
                ModelState.AddModelError("ImageFile", "Image size must be less than 2MB");
                return View();
            }
            string imageName=string.Concat( Guid.NewGuid().ToString() , slide.ImageFile.FileName);
            string directoryPath = "C:\\Users\\megru\\Desktop\\Programlar\\Github\\CodeAcademyAllTasks\\ASP.NET\\AdminPanel\\AdminPanel\\wwwroot\\assets\\images\\website-images\\"+slide.ImageFile.FileName;
            FileStream fileStream = new FileStream(directoryPath, FileMode.Create);
            await slide.ImageFile.CopyToAsync(fileStream);
            fileStream.Close();
            slide.ImagePath=slide.ImageFile.FileName;

            if (!ModelState.IsValid)
            {   
                return View();
            }
            _context.Sliders.Add(slide);
            _context.SaveChanges();
            return RedirectToAction("index");
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
