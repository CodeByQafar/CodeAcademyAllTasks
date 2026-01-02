using AdminPanel.Areas.Admin.ViewModels.Categoryes;
using AdminPanel.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Areas.Admin.Controllers.Category
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
                Categories=await _context.Categories.Include(c=>c.Products).ToListAsync()
            };
            return View(categoryVM);
        }

    
        public IActionResult Create()
        {
            return View();
        }
    }
}
