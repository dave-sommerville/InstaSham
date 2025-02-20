using Microsoft.AspNetCore.Mvc;

namespace InstaSham.Controllers
{
    public class DirectMessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
