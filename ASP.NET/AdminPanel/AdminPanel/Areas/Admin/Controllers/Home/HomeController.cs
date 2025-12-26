using AdminPanel.Areas.Admin.ViewModels.Home;
using AdminPanel.DAL;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Areas.Admin.Controllers.Home
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [Area("Admin")]

        public IActionResult Index()
        {

            //_context.Purchaces.AddRange(purchaceList);
            //_context.SaveChanges();

            HomeVM homeVM = new HomeVM
            {
                Purchaces = _context.Purchaces.ToList()
            };
            return View(homeVM);
        }

        //var purchaceList = new List<Purchace>
        //    {
        //        new Purchace
        //        {
        //            Name = "Alvin Fisher",
        //            StatusReport = "Ui design completed",
        //            Office = "East Mayra",
        //            Price = 23230,
        //            Date = new DateTime(2018, 7, 18),
        //            GrossAmount = 83127
        //        },
        //        new Purchace
        //        {
        //            Name = "Emily Cunningham",
        //            StatusReport = "support",
        //            Office = "Makennaton",
        //            Price = 939,
        //            Date = new DateTime(2018, 7, 16),
        //            GrossAmount = 29177
        //        },
        //        new Purchace
        //        {
        //            Name = "Minnie Farmer",
        //            StatusReport = "support",
        //            Office = "Agustinaborough",
        //            Price = 30,
        //            Date = new DateTime(2018, 4, 30),
        //            GrossAmount = 44617
        //        },
        //        new Purchace
        //        {
        //            Name = "Betty Hunt",
        //            StatusReport = "Ui design not completed",
        //            Office = "Lake Sandrafort",
        //            Price = 571,
        //            Date = new DateTime(2018, 6, 25),
        //            GrossAmount = 78952
        //        },
        //        new Purchace
        //        {
        //            Name = "Myrtie Lambert",
        //            StatusReport = "Ui design completed",
        //            Office = "Cassinbury",
        //            Price = 36,
        //            Date = new DateTime(2018, 11, 5),
        //            GrossAmount = 36422
        //        },
        //        new Purchace
        //        {
        //            Name = "Jacob Kennedy",
        //            StatusReport = "New project",
        //            Office = "Cletaborough",
        //            Price = 314,
        //            Date = new DateTime(2018, 7, 12),
        //            GrossAmount = 34167
        //        },
        //        new Purchace
        //        {
        //            Name = "Ernest Wade",
        //            StatusReport = "Levelled up",
        //            Office = "West Fidelmouth",
        //            Price = 484,
        //            Date = new DateTime(2018, 9, 8),
        //            GrossAmount = 50862
        //        }
        //    };
    }
}
