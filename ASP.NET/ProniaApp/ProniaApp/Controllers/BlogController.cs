using Microsoft.AspNetCore.Mvc;
using ProniaApp.DAL;
using ProniaApp.Models;

namespace ProniaApp.Controllers
{
    public class BlogController : Controller
    {
        public readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = new List<Blog>
            {
                new Blog
                {
                    
                    Title = "The Ultimate Guide to Summer Fashion",
                    Description = "Discover the latest trends and must-have pieces for a stylish summer wardrobe.",
                    ImageUrl = "summer-fashion.jpg",
                    Author = "Jane Doe",
                  CreatedAt = new DateTime(2023, 5, 12)

                },
                      new Blog
                {

                    Title = "The Snow Season",
                    Description = "Discover the latest trends and must-have pieces for a stylish winter wardrobe.",
                    ImageUrl = "winter-fashion.jpg",
                    Author = "Mike Abdurrahman",
                  CreatedAt = new DateTime(2024, 11, 10)

                },

            };
            _context.Blogs.AddRange(blogs);
            _context.SaveChanges();
            return View(blogs);

        }
    }
}

