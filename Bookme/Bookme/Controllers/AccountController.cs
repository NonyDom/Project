using Bookme.Database;
using Bookme.IHelper;
using Microsoft.AspNetCore.Mvc;

namespace Bookme.Controllers
{
    public class AccountController : Controller
    {
             private readonly ApplicationDbContext _context;
             private readonly IUserHelper _userHelper;

        public AccountController(ApplicationDbContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }
        [HttpGet]
        public IActionResult Registration()
        {
            ViewBag.Gender = _userHelper.DropDownOfGender();
            ViewBag.Category = _userHelper.DropDownOfCategory();
            return View();
        }
        
        




        public IActionResult Login()
        {
            return View();
        }

    }
}
