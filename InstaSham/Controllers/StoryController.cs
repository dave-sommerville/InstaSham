using Microsoft.AspNetCore.Mvc;

namespace InstaSham.Controllers
{
    public class StoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
