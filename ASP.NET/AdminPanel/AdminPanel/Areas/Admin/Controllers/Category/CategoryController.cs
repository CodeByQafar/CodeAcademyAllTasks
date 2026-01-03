using AdminPanel.Areas.Admin.ViewModels.Categoryes;
using AdminPanel.DAL;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Areas.Admin.Controllers.Categoryes
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            CategoryVM categoryVM = new CategoryVM
            {
                Categories = await _context.Categories.Include(c => c.Products).ToListAsync()
            };
            return View(categoryVM);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)

        {
            List<Category> categories = await _context.Categories.ToListAsync();
            bool isUsed = categories.Any(p => p.Name == category.Name);
            if (isUsed)
            {
                ModelState.AddModelError("Name", "This name is already used");
                return View();

            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return  RedirectToAction("Index");
          
        }

        public IActionResult Delete(int id)
        {
            Category? category = _context.Categories.Find(id);
            if (category == null) return NotFound();
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Detail(int id)
        {
            Category? category = _context.Categories.Include(c => c.Products).FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
    }
}
