using InstaSham.BLL;
using Microsoft.AspNetCore.Mvc;
using InstaSham.Models;

namespace InstaSham.Controllers
{
    public class StoryViewController : Controller
    {
        private readonly StoryViewService _storyViewService;
        public StoryViewController(StoryViewService storyViewService)
        {
            _storyViewService = storyViewService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<StoryView> storyViews = _storyViewService.GetsStoryViews();
            return View(storyViews);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StoryView storyView)
        {
            if(ModelState.IsValid)
            {
                StoryView newStoryView = new StoryView
                {
                    //Add properties
                };
                _storyViewService.AddStoryView(newStoryView);
                return RedirectToAction("Index");
            }
            return View(storyView);
        }
    }
}
