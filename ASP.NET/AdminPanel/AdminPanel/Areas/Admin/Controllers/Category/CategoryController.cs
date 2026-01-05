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
            return RedirectToAction("Index");

        }
        public IActionResult Detail(int id)
        {
            Category? category = _context.Categories.Include(c => c.Products).FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }


        public async Task<IActionResult> Update(int? id)
        {

            if (id < 1 || id == null)
            {
                return BadRequest();
            }
            Category category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
            if (category is null)
            {
                return NotFound();

            }
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, Category category)
        {

            if (id < 1 || id == null)
            {
                return BadRequest();
            }
            else if (category is null) {

                return NotFound();
            }
           Console.WriteLine("Category ID: " + category.Id);
            Category isCategoryExist =await _context.Categories.FirstOrDefaultAsync(p => p.Id == category.Id);
          
            if(isCategoryExist == null)
            {
                return NotFound();
            }
           if(isCategoryExist.Name== category.Name)
            {
                ModelState.AddModelError("Name", "New ctagory name can't be same old name");
                return View();
            }
                bool isExistName = await _context.Categories.AnyAsync(p => p.Name == category.Name);

            if (isExistName)
            {
                ModelState.AddModelError("Name", "this name used in other category");
                return View();
            }
            if (!ModelState.IsValid)
            {
                return View();

            }

            isCategoryExist.Name= category.Name;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

  
            //Category category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);
          
        }

        public IActionResult Delete(int id)
        {
            Category? category = _context.Categories.Find(id);
            if (category == null) return NotFound();
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
