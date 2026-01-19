using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Simulation5.Areas.Admin.ViewModels.Position4;
using Simulation5.DAL;
using Simulation5.Models;
using System.Threading.Tasks;

namespace Simulation5.Areas.Admin.Controllers.Position2
{
    [Area("Admin")]

    public class PositionController : Controller
    {

        public readonly AppDBContext _context;

        public PositionController(AppDBContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                positions = _context.positions.ToList(),

            };

            return View(homeVM);
        }


        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update(int? id)
        {
            return View();
        }
        public IActionResult Detail(int? id)
        {
            return View();
        }
   
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null || id < 1)
            {
                return BadRequest();

            }
            Position position = await _context.positions.FirstOrDefaultAsync(p => p.Id == id);
            if (position == null)
            {
                return BadRequest();

            }
          
            _context.positions.Remove(position);
            await _context.SaveChangesAsync();
            return RedirectToAction("index", "Position");
      
        }
        



        [HttpPost]
        public async Task<IActionResult> Create(CreateVM createVM)
        {
            if (!ModelState.IsValid)
            {
                return View(createVM);
            }
            Position position = new Position
            {
                Name = createVM.Name,
            };
            _context.positions.Add(position);
            await _context.SaveChangesAsync();
            return RedirectToAction("index", "Position");
        }


        [HttpPost]

        public async Task<IActionResult> Update(int? id, UpdateVM updateVM)
        {

            if (id == null || id < 1)
            {
                return BadRequest();

            }
            Position position =await  _context.positions.FirstOrDefaultAsync(p => p.Id == id);
            if (position == null)
            {
                return BadRequest();

            }
            position.Name = updateVM.Name;
            _context.positions.Update(position);
            await _context.SaveChangesAsync();
            return RedirectToAction("index", "Position");
        }
    }
}
