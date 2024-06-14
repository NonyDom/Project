using Microsoft.AspNetCore.Mvc;

namespace Bookme.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

