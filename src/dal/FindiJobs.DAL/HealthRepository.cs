using FindiJobs.DAL.Interfaces;
using FindiJobs.Models;

namespace FindiJobs.DAL
{
    public class HealthRepository : IHealthRepository
    {
        public Health GetHealth()
        {
            return new Health() { Message = "I'm FindiJobs-API and I'm alive and running! ;)" };
        }
    }
}
