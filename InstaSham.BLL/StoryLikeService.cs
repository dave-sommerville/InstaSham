using InstaSham.Models;
using InstaSham.DAL;

namespace InstaSham.BLL
{
   public class StoryLikeService
    {
        private readonly StoryLikeRepository _storyLikeRepository;
        public StoryLikeService(StoryLikeRepository storyLikeRepository)
        {
            _storyLikeRepository = storyLikeRepository;
        }
        public List<StoryLike> GetStoryLikes()
        {
            return _storyLikeRepository.GetAllStoryLikes();
        }
        public void AddStoryLike(StoryLike storyLike)
        {

        }
    }
}
