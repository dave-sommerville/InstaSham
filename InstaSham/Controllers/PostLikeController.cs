using InstaSham.BLL;
using InstaSham.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstaSham.Controllers
{
    public class PostLikeController : Controller
    {
        private readonly PostLikeService _postLikeService;
        public PostLikeController(PostLikeService postLikeService)
        {
            _postLikeService = postLikeService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<PostLike> postLikes = _postLikeService.GetPostlikes();
            return View(postLikes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PostLike postLike)
        {
            if (ModelState.IsValid)
            {
                PostLike newPostLike = new PostLike
                {
                    //Add properties here
                };
                _postLikeService.AddPostLike(newPostLike);
                return RedirectToAction("Index");
            }
            return View(postLike);
        }

    }
}
