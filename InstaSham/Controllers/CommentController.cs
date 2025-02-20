using Microsoft.AspNetCore.Mvc;
using InstaSham.BLL;
using InstaSham.Models;

namespace InstaSham.Controllers
{
    public class CommentController : Controller
    {
        private readonly CommentService _commentService;
        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Comment> comments = _commentService.GetComments();
            return View(comments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                Comment newComment = new Comment
                {
                    //add properties here 
                };
                _commentService.AddComment(newComment);
                return RedirectToAction("Index");
            }
            return View(comment);
        }

    }
}
