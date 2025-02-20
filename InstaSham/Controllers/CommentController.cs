using Microsoft.AspNetCore.Mvc;

namespace InstaSham.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
