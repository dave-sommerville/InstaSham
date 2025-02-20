using InstaSham.DAL;
using InstaSham.Models;

namespace InstaSham.BLL
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public void AddUser(User user)
        {

        }
    }
}
