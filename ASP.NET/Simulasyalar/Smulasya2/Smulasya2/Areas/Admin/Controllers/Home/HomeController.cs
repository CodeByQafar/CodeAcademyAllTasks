using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Smulasya2.Areas.Admin.ViewModel.Home;
using Smulasya2.DAL;
using Smulasya2.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Smulasya2.Areas.Admin.Controllers.Home
{

    [Area("Admin")]
    public class HomeController : Controller
    {
        public readonly AppDbContext _Context;
        public readonly IWebHostEnvironment _env;

        public HomeController(AppDbContext context, IWebHostEnvironment env )
        {
            _Context = context;
            _env = env;
        }


        public IActionResult Create(CreateVM createVM)
        {
            if (!ModelState.IsValid){
                return View(createVM);
            }
            if (createVM.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile",  "ImageFile doesnt exist");
                return View(createVM);

            }
            if (!createVM.ImageFile.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("ImageFile", "FileType Invalid");
                return View(createVM);

            }
            if (createVM.ImageFile.Length >= 2 * 1024 * 1024) 
            {
                ModelState.AddModelError("ImageFile", "ImageFile Size is More Big than 2MB");
                return View(createVM);
            }
            string filename = string.Concat(Guid.NewGuid().ToString(), createVM.ImageFile.FileName);
            string path = Path.Combine(_env.WebRootPath, "img", filename);
            Stream stream = new FileStream(path, FileMode.Create);
            createVM.
         List<Member> members = _Context.Members.ToList();
            return View(members);
        }
        public IActionResult Index()
        {
            List<Member> members = _Context.Members.ToList();
            return View(members);
        }



























































        //    public readonly AppDbContext _context;
        //    public readonly IWebHostEnvironment _env;
        //    public HomeController(AppDbContext context, IWebHostEnvironment env)
        //    {
        //        _context = context;
        //        _env = env;
        //    }
        //    public IActionResult Index()
        //    {
        //        List<Member> members = _context.Members.ToList();

        //        return View(members);
        //    }
        //    public IActionResult Create()
        //    {

        //        return View();
        //    }
        //    [HttpPost]
        //    public async Task<IActionResult> Create(CreateVM createVM)
        //    {

        //        if (createVM.ImageFile == null)
        //        {
        //            ModelState.AddModelError("ImageFile", "Image can't be null");
        //            return View(createVM);
        //        }
        //        else if (!createVM.ImageFile.ContentType.Contains("image/"))
        //        {
        //            ModelState.AddModelError("ImageFile", "image format is invaild");
        //            return View(createVM);

        //        }
        //        else if (createVM.ImageFile.Length > 2 * 1024 * 1024)
        //        {
        //            ModelState.AddModelError("ImageFile", "image size is must be lower than 2mb");

        //            return View(createVM);

        //        }
        //        if (!ModelState.IsValid)
        //        {
        //            return View(createVM);
        //        }
        //        string filename = String.Concat(Guid.NewGuid().ToString(), createVM.ImageFile.FileName);
        //        string path = Path.Combine(_env.WebRootPath, "img", filename);
        //        Stream stream = new FileStream(path, FileMode.Create);
        //        await createVM.ImageFile.CopyToAsync(stream);
        //        stream.Close();

        //        Member member = new Member
        //        {
        //            CreatedAt = DateTime.Now,
        //            FullName = createVM.FullName,
        //            Position = createVM.Position,
        //            isDeletet=false,
        //            ImageUrl = filename,
        //        };
        //        _context.Members.Add(member);
        //        _context.SaveChanges();
        //        return RedirectToAction("index","home");
        //    }

        //    public IActionResult Detail(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return BadRequest();            }

        //        Member member = _context.Members.FirstOrDefault(p => p.Id == id);
        //         if (member==null)
        //        {
        //            return BadRequest();
        //        }
        //        DetailVM detailVM = new DetailVM
        //        {
        //            FullName = member.FullName,
        //            Position = member.Position,
        //            ImageUrl = member.ImageUrl
        //        };
        //            return View(detailVM);
        //    }
        //    public IActionResult Update(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return BadRequest();
        //        }

        //        Member member = _context.Members.FirstOrDefault(p => p.Id == id);
        //        if (member == null)
        //        {
        //            return BadRequest();
        //        }
        //        UpdateVM updateVM = new UpdateVM
        //        {
        //            FullName = member.FullName,
        //            Position = member.Position,
        //            ImageUrl = member.ImageUrl,

        //        };

        //        return View(updateVM);
        //    }
        //    [HttpPost]
        //    public async Task< IActionResult> Update(int? id,UpdateVM updateVM)
        //    {
        //        if (id == null)
        //        {
        //            return BadRequest();
        //        }

        //        Member member = _context.Members.FirstOrDefault(p => p.Id == id);
        //        if (member == null)
        //        {
        //            return BadRequest();
        //        }
        //        if (updateVM.ImageFile != null)
        //        {
        //            if (!updateVM.ImageFile.ContentType.Contains("image/"))
        //            {
        //                ModelState.AddModelError("ImageFile", "image format is invaild");
        //                return View(updateVM);

        //            }
        //            else if (updateVM.ImageFile.Length > 2 * 1024 * 1024)
        //            {
        //                ModelState.AddModelError("ImageFile", "image size is must be lower than 2mb");

        //                return View(updateVM);

        //            }
        //            else
        //            { 
        //                if (!ModelState.IsValid)
        //                {
        //                    return View(updateVM);
        //                }
        //                string filename = String.Concat(Guid.NewGuid().ToString(), updateVM.ImageFile.FileName);
        //                string path = Path.Combine(_env.WebRootPath, "img", filename);
        //                Stream stream = new FileStream(path, FileMode.Create);
        //                await updateVM.ImageFile.CopyToAsync(stream);
        //                stream.Close();


        //                member.Position = updateVM.Position;
        //                member.FullName = updateVM.FullName;
        //                member.ImageUrl = filename;
        //                _context.Members.Update(member);
        //                _context.SaveChanges();
        //                return RedirectToAction("index", "home");
        //            }
        //        }

        //        else
        //        {
        //            member.Position = updateVM.Position;
        //            member.FullName = updateVM.FullName;


        //            _context.Members.Update(member);
        //            return RedirectToAction("index", "home");

        //        }



        //    }

        //    public IActionResult Delete(int ? id)
        //    {
        //        if (id == null)
        //        {
        //            return BadRequest();
        //        }

        //        Member member = _context.Members.FirstOrDefault(p => p.Id == id);
        //        if (member == null)
        //        {
        //            return BadRequest();
        //        }
        //        _context.Members.Remove(member);
        //        _context.SaveChanges();
        //        return RedirectToAction("index","home");
        //    }
    }
}
