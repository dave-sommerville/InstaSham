using InstaSham.DAL;
using InstaSham.Models;

namespace InstaSham.BLL
{
    public class StoryService
    {
        private readonly StoryRepository _storyRepository;
        public StoryService(StoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }
        public List<Story> GetStories()
        {
            return _storyRepository.GetAllStories();
        }
        public void AddStory(Story story)
        {

        }
    }
}
