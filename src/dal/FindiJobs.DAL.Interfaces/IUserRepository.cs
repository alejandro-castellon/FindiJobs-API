using FindiJobs.Models;

namespace FindiJobs.DAL.Interfaces
{
    public interface IUserRepository
    {
        public User Add(User user);

        public User GetById(int id);

        public List<User> GetAll();

        public User Update(int id, User updatesData);

        public void Delete(int id);
    }
}
