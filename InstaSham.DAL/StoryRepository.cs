using InstaSham.Models;

namespace InstaSham.DAL
{
    public class StoryRepository
    {
        private readonly InstaShamContext _context;
        public StoryRepository(InstaShamContext context)
        {
            _context = context;
        }
        public List<Story> GetAllStories()
        {
            return _context.Stories.ToList();
        }
        public void AddStory(Story story)
        {
            _context.Stories.Add(story);
            _context.SaveChanges();
        }
    }
}
