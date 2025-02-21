using InstaSham.Models;

namespace InstaSham.DAL
{
    public class StoryLikeRepository
    {
        private readonly InstaShamContext _context;
        public StoryLikeRepository(InstaShamContext context)
        {
            _context = context;
        }
        public List<StoryLike> GetAllStoryLikes()
        {
            return _context.StoryLikes.ToList();
        }
        public void AddStoryLike(StoryLike storyLike)
        {
            _context.StoryLikes.Add(storyLike);
            _context.SaveChanges();
        }
    }
}
