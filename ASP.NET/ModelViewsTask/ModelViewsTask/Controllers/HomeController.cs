using Microsoft.AspNetCore.Mvc;

namespace ModelViewsTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewModel
            {
                Products = new List<Product>
            {
                new Product
                {
                    Image = "p1.jpg",
                    Name = "Product 1",
                    Description = "Description 1",
                    Price = 100,
                    DiscountPrice = 80,
                    Category = "Electronics",
                    Color = "Black"
                },
                new Product
                {
                    Image = "p2.jpg",
                    Name = "Product 2",
                    Description = "Description 2",
                    Price = 150,
                    DiscountPrice = 120,
                    Category = "Clothes",
                    Color = "Red"
                }
            }
            };

            return View(model);
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}
