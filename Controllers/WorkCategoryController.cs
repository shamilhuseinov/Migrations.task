using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.WorkCategory;

namespace PurpleBuzz.Controllers
{
    public class WorkCategoryController : Controller
    {
        private readonly AppDbContext _context;

        public WorkCategoryController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(WorkCategoryCreateVM model)
        {
            if (!ModelState.IsValid) return View();

            var workCategory = _context.WorkCategories.FirstOrDefault(wc => wc.Name.ToLower() == model.Name.ToLower());
            if (workCategory is not null)
            {
                ModelState.AddModelError("Name", "Bu adda kateqoriya mövcuddur");
                return View();
            }
            
            workCategory = new WorkCategory
            {
                Name = model.Name,
                Description = model.Description
            };

            _context.WorkCategories.Add(workCategory);
            _context.SaveChanges();

            return Ok(workCategory);
        }
    }
}
