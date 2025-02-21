using Microsoft.AspNetCore.Mvc;
using InstaSham.BLL;
using InstaSham.Models;

namespace InstaSham.Controllers
{
    public class StoryLikeController : Controller
    {
        private readonly StoryLikeService _storyLikeService;
        public StoryLikeController(StoryLikeService storyLikeService)
        {
            _storyLikeService = storyLikeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StoryLike storyLike)
        {
            if(ModelState.IsValid)
            {
                StoryLike newStoryLike = new StoryLike
                {
                    //Add properties here
                };
                _storyLikeService.AddStoryLike(newStoryLike);
                return RedirectToAction("Index");
            }
            return View(storyLike);
        }

    }
}
