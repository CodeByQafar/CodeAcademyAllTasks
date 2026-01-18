using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simulasya3.Areas.Admin.ViewModels.Home;
using Simulasya3.DAL;
using Simulasya3.Models;
using Simulasya3.ViewModels.Home;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Authorization;
namespace Simulasya3.Areas.Admin.Controllers.Home
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public readonly IWebHostEnvironment _env;
        public HomeController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Team> _teams = await _context.Teams.ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                teams = _teams
            };
            return View(homeVM);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update(int? id)
        {
            Team team = _context.Teams.FirstOrDefault(p => p.Id == id);
            if (team == null)
            {
                return NotFound();
            }
            UpdateVM updateVM = new UpdateVM
            {
                FullName = team.FullName,
                Position = team.Position,
                ImageUrl = team.ImageUrl,
                Order = team.Order
            };
            return View(updateVM);
        }
        public IActionResult Detail(int? id)
        {
            Team team = _context.Teams.FirstOrDefault(p => p.Id == id);
            if (team == null)
            {
                return NotFound();

            }
            DetailVM detailVM = new DetailVM
            {
                Id = team.Id,
                FullName = team.FullName,
                Position = team.Position,
                CreatedAt = team.CreatedAt,
                ImageUrl = team.ImageUrl,
                isDeleted = team.isDeleted,
                Order = team.Order
            };
            return View(detailVM);
        }



        [HttpPost]
        public async Task<IActionResult> Create(CreateVM createVM)
        {
            if (!ModelState.IsValid)
            {
                return View(createVM);
            }

            if (createVM.ImageFile != null)
            {
                if (createVM.ImageFile.ContentType.Contains("image/"))
                {
                    if (createVM.ImageFile.Length < 2 * 1024 * 1024)
                    {

                        string fileName = String.Concat(Guid.NewGuid().ToString(), createVM.ImageFile.FileName);
                        string path = Path.Combine(_env.WebRootPath, "assets", "img", "team", fileName);
                        Stream stream = new FileStream(path, FileMode.Create);
                        await createVM.ImageFile.CopyToAsync(stream);
                        stream.Close();
                        createVM.ImageUrl = fileName;
                        Team newTeam = new Team
                        {
                            FullName = createVM.FullName,
                            Position = createVM.Position,
                            CreatedAt = DateTime.Now,
                            ImageUrl = fileName,
                            isDeleted = false,
                            Order = createVM.Order
                        };
                        _context.Teams.Add(newTeam);
                        _context.SaveChanges();
                        return RedirectToAction("Index");

                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "image can't be larger than 2mb");
                        return View(createVM);
                    }
                }
                else
                {
                    ModelState.AddModelError("ImageFile", "file type is not valid");
                    return View(createVM);
                }
            }
            else
            {
                ModelState.AddModelError("ImageFile", "please uplad image");
                return View(createVM);
            }

        }
        [HttpPost]

        public async Task<IActionResult> Update(int? id, UpdateVM updateVM)
        {
            Team team = _context.Teams.FirstOrDefault(p => p.Id == id);
            if (team == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(updateVM);
            }

            if (updateVM.ImageFile != null)
            {
                if (updateVM.ImageFile.ContentType.Contains("image/"))
                {
                    if (updateVM.ImageFile.Length < 2 * 1024 * 1024)
                    {

                        string fileName = String.Concat(Guid.NewGuid().ToString(), updateVM.ImageFile.FileName);
                        string path = Path.Combine(_env.WebRootPath, "assets", "img", "team", fileName);
                        Stream stream = new FileStream(path, FileMode.Create);
                        await updateVM.ImageFile.CopyToAsync(stream);
                        stream.Close();
                        //File.Delete( Path.Combine(_env.WebRootPath, "assets", "img", "team", team.ImageUrl));
                        team.FullName = updateVM.FullName;
                        team.Position = updateVM.Position;
                        team.Order = updateVM.Order;
                        team.ImageUrl = fileName;
                        _context.Teams.Update(team);
                        _context.SaveChanges();
                        return RedirectToAction("Index");

                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "image can't be larger than 2mb");
                        return View(updateVM);
                    }
                }
                else
                {
                    ModelState.AddModelError("ImageFile", "file type is not valid");
                    return View(updateVM);
                }
            }
            else
            {


                team.FullName = updateVM.FullName;
                team.Position = updateVM.Position;
                team.Order = updateVM.Order;

                _context.Teams.Update(team);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
       

        public IActionResult Delete(int? id)
        {
            Team team = _context.Teams.FirstOrDefault(p => p.Id == id);
            if (team == null)
            {
                return NotFound();

            }
            _context.Teams.Remove(team);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
