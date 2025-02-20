using Microsoft.AspNetCore.Mvc;
using InstaSham.BLL;
using InstaSham.Models;

namespace InstaSham.Controllers
{
    public class StoryController : Controller
    {
        private readonly StoryService _storyService;
        public StoryController(StoryService storyService)
        {
            _storyService = storyService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Story> stories = _storyService.GetStories();
            return View(stories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Story story)
        {
            if (ModelState.IsValid)
            {
                Story newStory = new Story
                {
                    //Add properties here
                };
                _storyService.AddStory(newStory);
                return RedirectToAction("Index");
            }
            return View(story);
        }
    }
}
