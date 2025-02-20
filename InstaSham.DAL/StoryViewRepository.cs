using InstaSham.Models;

namespace InstaSham.DAL
{
    public class StoryViewRepository
    {
        private readonly InstaShamContext _context;
        public StoryViewRepository(InstaShamContext context)
        {
            _context = context;
        }
        public List<StoryView> GetAllStoryViews()
        {
            return _context.StoryViews.ToList();
        }
        public void AddStoryView(StoryView storyView)
        {
            _context.StoryViews.Add(storyView);
            _context.SaveChanges();
        }
    }
}
