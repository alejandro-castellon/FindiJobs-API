using FindiJobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindiJobs.Core.Interfaces
{
    public interface IUserService
    {
        User PostUser(User user);

        public User GetUser(int id);

        List<User> GetUsers();

        public void RemoveUser(int id);

        User UpdateProject(User user);
    }
}
