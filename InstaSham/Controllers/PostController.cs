using Microsoft.AspNetCore.Mvc;
using InstaSham.BLL;
using InstaSham.Models;

namespace InstaSham.Controllers
{
    public class PostController : Controller
    {
        private readonly PostService _postService;
        public PostController(PostService postService)
        {
            _postService = postService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Post> posts = _postService.GetPosts();
            return View(posts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                Post newPost = new Post
                {
                    //Add properties here
                };
                _postService.AddPost(newPost);
                return RedirectToAction("Index");
            }
            return View(post);
        }
    }
}
