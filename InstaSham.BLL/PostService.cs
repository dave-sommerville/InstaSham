using InstaSham.DAL;
using InstaSham.Models;

namespace InstaSham.BLL
{
    public class PostService
    {
        private readonly PostRepository _postRepository;
        public PostService(PostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public List<Post> GetPosts()
        {
            return _postRepository.GetAllPosts();
        }
        public void AddPost(Post post)
        {

        }
    }
}
