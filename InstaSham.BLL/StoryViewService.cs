using InstaSham.DAL;
using InstaSham.Models;

namespace InstaSham.BLL
{
    public class StoryViewService
    {
        private readonly StoryViewRepository _storyViewRepository;
        public StoryViewService(StoryViewRepository storyViewRepository)
        {
            _storyViewRepository = storyViewRepository;
        }
        public List<StoryView> GetsStoryViews()
        {
            return _storyViewRepository.GetAllStoryViews();
        }
        public void AddPost(StoryView storyView)
        {

        }
    }
}
