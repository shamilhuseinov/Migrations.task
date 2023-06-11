using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.Home;

namespace PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View(new HomeIndexVM());
        }
    }
}
