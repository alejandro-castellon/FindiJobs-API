using FindiJobs.Models;
using Microsoft.EntityFrameworkCore;

namespace FindiJobs.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
