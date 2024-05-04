using FindiJobs.Models;

namespace FindiJobs.DAL.Interfaces
{
    public interface IUserRepository
    {
        public User Add(User newObject);

        public User GetById(int id);

        public List<User> GetAll();

        public User Update(User updateObject);

        public void Delete(int id);
    }
}
