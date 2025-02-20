using InstaSham.DAL;
using InstaSham.Models;

namespace InstaSham.BLL
{
    public class DirectMessageService
    {
        private readonly DirectMessageRepository _directMessageRepository;
        public DirectMessageService(DirectMessageRepository directMessageRepository)
        {
            _directMessageRepository = directMessageRepository;
        }
        public List<DirectMessage> GetDirectMessages()
        {
            return _directMessageRepository.GetAllDirectMessages();
        }
        public void AddDirectMessage(DirectMessage directMessage)
        {

        }
    }
}
