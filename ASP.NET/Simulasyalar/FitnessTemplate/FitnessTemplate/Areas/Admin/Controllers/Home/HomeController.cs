using FitnessTemplate.DAL;
using FitnessTemplate.Models;
using FitnessTemplate.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FitnessTemplate.Areas.Admin.Controllers.Home
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public readonly IWebHostEnvironment _env;
        public HomeController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Trainer> trainers = _context.Trainers.ToList();
            HomeVM homeVM = new HomeVM
            {
                Trainers = trainers
            };
            return View(homeVM);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Trainer trainer)
        {

            if (trainer.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "ImageFile is required");
                return View(trainer);
            }
            if (trainer.ImageFile.Length > 2 * 1024 * 1024)
            {
                ModelState.AddModelError("ImageFile", "ImageFile size can't be larger than 2mb");
                return View(trainer);
            }
            if (!trainer.ImageFile.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("ImageFile", "This file type is not valid");
                return View(trainer);
            }
            if (!ModelState.IsValid)
            {
                return View(trainer);
            }
            string fileName = String.Concat(Guid.NewGuid().ToString(), trainer.ImageFile.FileName);
            string path = Path.Combine(_env.WebRootPath, "images", fileName);
            FileStream stream = new FileStream(path, FileMode.Create);
            await trainer.ImageFile.CopyToAsync(stream);
            stream.Close();
            trainer.ImageUrl = fileName;
     
            _context.Trainers.Add(trainer);
            _context.SaveChangesAsync();
            return RedirectToAction("index");
        }


        public IActionResult Delete(int? id)
        {
            if (id == null ||id<1)
            {
                return BadRequest();
            }
            bool isExsist = _context.Trainers.Any(p => p.Id == id);
            if (!isExsist)
            {
                return BadRequest();

            }
            Trainer trainer = _context.Trainers.FirstOrDefault(p => p.Id == id);
            _context.Trainers.Remove(trainer);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Update(int? id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }
            bool isExsist = _context.Trainers.Any(p => p.Id == id);
            if (!isExsist)
            {
                return BadRequest();

            }
            Trainer trainer = _context.Trainers.FirstOrDefault(p => p.Id == id);

            return View(trainer);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id,Trainer trainer)
        {


            if (trainer.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "ImageFile is required");
                return View(trainer);
            }
            if (trainer.ImageFile.Length > 2 * 1024 * 1024)
            {
                ModelState.AddModelError("ImageFile", "ImageFile size can't be larger than 2mb");
                return View(trainer);
            }
            if (!trainer.ImageFile.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("ImageFile", "This file type is not valid");
                return View(trainer);
            }
            if (!ModelState.IsValid)
            {
                return View(trainer);
            }
            string fileName = String.Concat(Guid.NewGuid().ToString(), trainer.ImageFile.FileName);
            string path = Path.Combine(_env.WebRootPath, "images", fileName);
            FileStream stream = new FileStream(path, FileMode.Create);
            await trainer.ImageFile.CopyToAsync(stream);
            stream.Close();
            trainer.ImageUrl = fileName;
            trainer.Id = id;
            _context.Trainers.Update(trainer);
         await   _context.SaveChangesAsync();
            return RedirectToAction("index");
        }
        public IActionResult Detail(int? id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }
            bool isExsist = _context.Trainers.Any(p => p.Id == id);
            if (!isExsist)
            {
                return BadRequest();

            }
            Trainer trainer = _context.Trainers.FirstOrDefault(p => p.Id == id);
         
            return View(trainer);
        }
    }

}
