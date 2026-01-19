using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simulation5.Areas.Admin.ViewModels.Chefs;
using Simulation5.DAL;
using Simulation5.Models;
using System.Threading.Tasks;

namespace Simulation5.Areas.Admin.Controllers.Chefscon
{
    [Area("Admin")]

    public class ChefController : Controller
    {
        public readonly AppDBContext _context;
        public readonly IWebHostEnvironment _env;
        public ChefController(AppDBContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Create()
        {
            CreateVM createVM = new CreateVM
            {
                Positions = _context.positions.ToList()
            };
            return View(createVM);
        }
        public async Task<IActionResult> Update(int? id)
        {


            if (id == null || id < 1)
            {
                return BadRequest();

            }
            Chef chef = await _context.chefs.FirstOrDefaultAsync(p => p.Id == id);
            if (chef == null)
            {
                return BadRequest();
            }

            UpdateVM createVM = new UpdateVM
            {
                FullName = chef.FullName,
                Description = chef.Description,
                PositionId = chef.PositionId,
                Positions = _context.positions.ToList()

            };
            return View(createVM);

        }
        public async Task<IActionResult> Detail(int? id)
        {

            if (id == null || id < 1)
            {
                return BadRequest();

            }
            Chef chef = await _context.chefs.FirstOrDefaultAsync(p => p.Id == id);
            if (chef == null)
            {
                return BadRequest();
            }

            DetailVM detailVM = new DetailVM
            {
                FullName = chef.FullName,
                Description = chef.Description,
                PositionId = chef.PositionId,
                Position = await _context.positions.FirstOrDefaultAsync(p => p.Id == chef.PositionId),
                ImageUrl = chef.ImageUrl,
            };
            return View(detailVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateVM createVM)
        {
            createVM.Positions = _context.positions.ToList();
            if (!ModelState.IsValid)
            {

                return View(createVM);
            }

            if (createVM.imageFile != null)
            {
                if (createVM.imageFile.ContentType.Contains("image/"))
                {

                    if (createVM.imageFile.Length < 2 * 1024 * 1024)
                    {
                        string filename = string.Concat(Guid.NewGuid().ToString(), createVM.imageFile.FileName);
                        string path = Path.Combine(_env.WebRootPath, "images", filename);
                        Stream stream = new FileStream(path, FileMode.Create);
                        await createVM.imageFile.CopyToAsync(stream);
                        stream.Close();
                        createVM.ImageUrl = filename;

                        Chef chef = new Chef
                        {
                            CreatetAt = DateTime.Now,
                            FullName = createVM.FullName,
                            Description = createVM.Description,
                            ImageUrl = filename,
                            PositionId = createVM.PositionId,


                        };

                        await _context.chefs.AddAsync(chef);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        ModelState.AddModelError("imageFile", "file can't be larger than 2mb");
                        return View(createVM);
                    }
                }
                else
                {
                    ModelState.AddModelError("imageFile", "file type is invalid");
                    return View(createVM);

                }
            }
            else
            {
                ModelState.AddModelError("imageFile", "image file can't be null");
                return View(createVM);

            }

        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, UpdateVM updateVM)
        {

            if (id == null || id < 1)
            {
                return BadRequest();

            }
            Chef chef = await _context.chefs.FirstOrDefaultAsync(p => p.Id == id);
            if (chef == null)
            {
                return BadRequest();
            }

            updateVM.Positions = _context.positions.ToList();
            if (!ModelState.IsValid)
            {

                return View(updateVM);
            }

            if (updateVM.imageFile != null)
            {
                if (updateVM.imageFile.ContentType.Contains("image/"))
                {

                    if (updateVM.imageFile.Length < 2 * 1024 * 1024)
                    {
                        string filename = string.Concat(Guid.NewGuid().ToString(), updateVM.imageFile.FileName);
                        string path = Path.Combine(_env.WebRootPath, "images", filename);
                        Stream stream = new FileStream(path, FileMode.Create);
                        await updateVM.imageFile.CopyToAsync(stream);
                        stream.Close();
                        updateVM.ImageUrl = filename;

                        chef.FullName = updateVM.FullName;
                        chef.Description = updateVM.Description;
                        chef.PositionId = updateVM.PositionId;
                        chef.ImageUrl = updateVM.ImageUrl;

                        _context.chefs.Update(chef);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        ModelState.AddModelError("imageFile", "file can't be larger than 2mb");
                        return View(updateVM);
                    }
                }
                else
                {
                    ModelState.AddModelError("imageFile", "file type is invalid");
                    return View(updateVM);

                }
            }
            else
            {
                chef.FullName = updateVM.FullName;
                chef.Description = updateVM.Description;
                chef.PositionId = updateVM.PositionId;


                _context.chefs.Update(chef);
                await _context.SaveChangesAsync();
                return RedirectToAction("index", "home");


            }


        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();

            }
            Chef chef = await _context.chefs.FirstOrDefaultAsync(p => p.Id == id);
            if (chef == null)
            {
                return BadRequest();

            }

            _context.chefs.Remove(chef);
            await _context.SaveChangesAsync();
            return RedirectToAction("index", "home");
        }



    }
}
