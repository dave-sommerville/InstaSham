using InstaSham.DAL;
using InstaSham.Models;

namespace InstaSham.BLL
{
    public class CommentService
    {
        private readonly CommentRepository _commentRepository;
        public CommentService(CommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public List<Comment> GetComments()
        {
            return _commentRepository.GetAllComments();
        }
        public void AddComment(Comment comment)
        {
            
        }
    }
}
