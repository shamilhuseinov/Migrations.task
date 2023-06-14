using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.DAL;
using PurpleBuzz.ViewModels.Work;

namespace PurpleBuzz.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;

        public WorkController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            var transformComponent = _context.TransformComponents.FirstOrDefault(tc => !tc.IsDeleted);
            var workCategories = _context.WorkCategories
                                        .Include(x => x.Works)
                                        .ToList();

            var model = new WorkIndexVM
            {
                WorkCategories = workCategories,
                TransformComponent=transformComponent
            };

            return View(model);
        }
    }
}
