using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Simulation6.Areas.Admin.ViewModels.Home;
using Simulation6.DAL;
using Simulation6.Models;
using Simulation6.Utilities.Enums;
using Simulation6.Utilities.Extensions;

namespace Simulation6.Areas.Admin.Controllers.Home
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Moderator")]
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;
        public readonly IWebHostEnvironment _env;

        public HomeController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Project> projects = _context.Projects.ToList();
            HomeVM homeVM = new HomeVM
            {
                Projects = projects
            };
            return View(homeVM);
        }

        public IActionResult Create()
        {

            return View();
        }

        public IActionResult Detail(int? Id)
        {
            if (Id == null || Id < 1)
            {
                return BadRequest();
            }
            Project project = _context.Projects.FirstOrDefault(p => p.Id == Id);
            if (project == null)
            {
                return NotFound();
            }
            DetailVM detailVM = new DetailVM
            {
                Title = project.Title,
                ProjectType = project.ProjectType,
                ImageUrl= project.ImageUrl
            };
            return View(detailVM);
        }

        public IActionResult Update(int? Id)
        {
            if (Id == null || Id < 1)
            {
                return BadRequest();
            }
            Project project = _context.Projects.FirstOrDefault(p => p.Id == Id);
            if (project == null)
            {
                return NotFound();
            }
            UpdateVM updateVM = new UpdateVM
            {
                Title = project.Title,
                ProjectType = project.ProjectType,

            };
            return View(updateVM);
        }



        [HttpPost]
        public async Task<IActionResult> Create(CreateVM createVM)
        {
            if (!ModelState.IsValid)
            {
                return View(createVM);
            }
            if (createVM.imageFile != null)
            {
                if (FileValidator.FileTypeValidator(createVM.imageFile,"image/"))
                {
                    if (FileValidator.FileSizeValidator(createVM.imageFile,FileSize.MB,2))
                    {
                     string fileName=await   FileValidator.FileCreate(createVM.imageFile, _env.WebRootPath, "assets", "images");
                        Project newProject = new Project
                        {
                            Title= createVM.Title,
                            ProjectType= createVM.ProjectType,
                            ImageUrl= fileName,
                            CreatedtAt=DateTime.Now,
                            IsDeleted=false
                            
                        };
                        _context.Projects.Add(newProject);
                        _context.SaveChanges();
                        return RedirectToAction("index", "home");

                    }
                    else
                    {
                        ModelState.AddModelError("imageFile", "Image file is can't biger than 2mb");
                        return View(createVM);
                    }
                }
                else
                {
                    ModelState.AddModelError("imageFile", "file type is invaild");
                    return View(createVM);
                }

            }
            else
            {
                ModelState.AddModelError("imageFile", "Image file is can't be null");
                return View(createVM);
            }
        }
        [HttpPost]


        public async Task<IActionResult> Update(int? Id, UpdateVM updateVM)
        {
            if (Id == null || Id < 1)
            {
                return BadRequest();
            }
            Project project = _context.Projects.FirstOrDefault(p => p.Id == Id);
            if (project == null)
            {
                return NotFound();
            }



            if (!ModelState.IsValid)
            {
                return View(updateVM);
            }
            if (updateVM.imageFile != null)
            {
                if (FileValidator.FileTypeValidator(updateVM.imageFile, "image/"))
                {
                    if (FileValidator.FileSizeValidator(updateVM.imageFile, FileSize.MB, 2))
                    {
                        project.ImageUrl.FileDelete(_env.WebRootPath, "assets", "images");
                        string fileName = await FileValidator.FileCreate(updateVM.imageFile, _env.WebRootPath, "assets", "images");
                         project.Title= updateVM.Title;
                        project.ProjectType= updateVM.ProjectType;  
                        project.ImageUrl= fileName;


                        _context.Projects.Update(project);
                        _context.SaveChanges();
                        return RedirectToAction("index", "home");

                    }
                    else
                    {
                        ModelState.AddModelError("imageFile", "Image file is can't biger than 2mb");
                        return View(updateVM);
                    }
                }
                else
                {
                    ModelState.AddModelError("imageFile", "file type is invaild");
                    return View(updateVM);
                }

            }
            else
            {
                project.Title = updateVM.Title;
                project.ProjectType = updateVM.ProjectType;
              


                _context.Projects.Update(project);
                _context.SaveChanges();
                return RedirectToAction("index", "home");
            }
          
        }
       
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id < 1)
            {
                return BadRequest();
            }
            Project project = _context.Projects.FirstOrDefault(p => p.Id == Id);
            if (project == null)
            {
                return NotFound();
            }
            _context.Projects.Remove(project);
            _context.SaveChanges();
            return RedirectToAction("index", "home");
        }


    }
}
