using Microsoft.AspNetCore.Mvc;
using InstaSham.BLL;
using InstaSham.Models;

namespace InstaSham.Controllers
{
    public class DirectMessageController : Controller
    {
        private readonly DirectMessageService _directMessageService;
        public DirectMessageController(DirectMessageService directMessageService)
        {
            _directMessageService = directMessageService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<DirectMessage> directMessages = _directMessageService.GetDirectMessages();
            return View(directMessages);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DirectMessage directMessage)
        {
            if(ModelState.IsValid)
            {
                DirectMessage newDirectMessage = new DirectMessage
                {
                    //Add properties here
                };
                _directMessageService.AddDirectMessage(newDirectMessage);
                return RedirectToAction("Index");
            }
            return View(directMessage);
        }
    }
}
