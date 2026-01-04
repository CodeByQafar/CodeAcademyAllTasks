using AdminPanel.DAL;
using AdminPanel.Models;
using AdminPanel.ViewModels.Shop;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers.Shop
{
    public class ShopController : Controller
    {
        AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ShopVM shopVM = new ShopVM
            {
                Products = _context.Products.Include(p => p.ProductImages).Include(p=>p.Category).ToList()
            };


            return View(shopVM);
        }
        public async Task<IActionResult> Detail(int id)
        {
            if (id == 0 || id < 1) return BadRequest();
            Product product = await _context.Products
    .Include(p => p.ProductImages)
    .Include(p => p.Category)
    .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) return NotFound();
            List<Product> realatedProducts =await _context.Products.Include(p=>p.ProductImages).Include(p => p.Category).Where(p => p.CategoryId == product.CategoryId).ToListAsync();

            DetailVM detailVM = new DetailVM
            {
                Product = product,
                RealetdProducts = realatedProducts

            };
            return View(detailVM);
        }
    }
}
