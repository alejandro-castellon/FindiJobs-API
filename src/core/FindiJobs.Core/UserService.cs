using FindiJobs.Core.Interfaces;
using FindiJobs.DAL.Interfaces;
using FindiJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public void RemoveUser(int id)
        {
            throw new NotImplementedException();
        }

        public User UpdateProject(User user)
        {
            throw new NotImplementedException();
        }
    }
}
