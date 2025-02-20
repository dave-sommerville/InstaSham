using Microsoft.AspNetCore.Mvc;

namespace InstaSham.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
