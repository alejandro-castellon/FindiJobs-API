using FindiJobs.DAL.Interfaces;
using FindiJobs.Models;

namespace FindiJobs.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public User Add(User newObject)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public User Update(User updateObject)
        {
            throw new NotImplementedException();
        }
    }
}
