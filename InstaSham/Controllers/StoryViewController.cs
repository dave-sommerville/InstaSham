using Microsoft.AspNetCore.Mvc;

namespace InstaSham.Controllers
{
    public class StoryViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
