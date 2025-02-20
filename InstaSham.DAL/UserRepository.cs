using InstaSham.Models;

namespace InstaSham.DAL
{
    public class UserRepository
    {
        private readonly InstaShamContext _context;
        public UserRepository(InstaShamContext context)
        {
            _context = context;
        }
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
