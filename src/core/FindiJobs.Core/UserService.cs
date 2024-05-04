using FindiJobs.Core.Interfaces;
using FindiJobs.Core.Validators;
using FindiJobs.DAL.Interfaces;
using FindiJobs.Models;
using FluentValidation;

namespace FindiJobs.Core
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User GetUser(int id)
        {
            return this.userRepository.GetById(id);
        }

        public List<User> GetUsers()
        {
            return this.userRepository.GetAll();
        }

        public User PostUser(User user)
        {
            UserValidator validator = new UserValidator();
            validator.ValidateAndThrow(user);
            return this.userRepository.Add(user);
        }

        public void RemoveUser(int id)
        {
            this.userRepository.Delete(id);
        }

        public User UpdateUser(int id, User updatedData)
        {
            UserValidator validator = new UserValidator();
            validator.ValidateAndThrow(updatedData);
            return this.userRepository.Update(id, updatedData);
        }
    }
}
