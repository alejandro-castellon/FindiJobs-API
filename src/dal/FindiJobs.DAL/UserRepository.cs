using FindiJobs.DAL.Interfaces;
using FindiJobs.Models;
using System;

namespace FindiJobs.DAL
{
    public class UserRepository : IUserRepository
    {
        public User Add(User user)
        {
            var db = new DataContext();
            db.Add(user);
            db.SaveChanges();
            return user;
        }

        public void Delete(int id)
        {
            var db = new DataContext();
            var user = db.Users.FirstOrDefault(x => x.Id == id);
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public List<User> GetAll()
        {
            var db = new DataContext();
            return db.Users.ToList();
        }

        public User GetById(int id)
        {
            var db = new DataContext();
            return db.Users.FirstOrDefault(x => x.Id == id);
        }

        public User Update(int id, User updatedData)
        {
            var db = new DataContext();
            var user = db.Users.FirstOrDefault(x => x.Id == id);
            user.Name = updatedData.Name;
            user.Email = updatedData.Email;
            user.Password = updatedData.Password;
            db.SaveChanges();
            return user;
        }
    }
}
