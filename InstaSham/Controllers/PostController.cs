using Microsoft.AspNetCore.Mvc;

namespace InstaSham.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
