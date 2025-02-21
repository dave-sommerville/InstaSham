using InstaSham.Models;

namespace InstaSham.DAL
{
    public class PostRepository
    {
        private readonly InstaShamContext _context;
        public PostRepository(InstaShamContext context  )
        {
            _context = context;
        }
        public List<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }
        public void AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }
    }
}
