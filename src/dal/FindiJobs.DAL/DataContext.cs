using FindiJobs.Models;
using Microsoft.EntityFrameworkCore;

namespace FindiJobs.DAL
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-VF52GS6\\TEW_SQLEXPRESS;Initial Catalog=FindiJobsDb;Integrated Security=True;Trust Server Certificate=True");
            }
        }
    }
}
