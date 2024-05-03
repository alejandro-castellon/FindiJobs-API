using FindiJobs.Models;
using FindiJobs.Core.Interfaces;
using FindiJobs.DAL.Interfaces;

namespace FindiJobs.Core
{
    public class HealthService : IHealthService
    {
        private readonly IHealthRepository healthRepository;

        public HealthService(IHealthRepository healthRepository)
        {
            this.healthRepository = healthRepository;
        }

        public Health GetHealth()
        {
            return this.healthRepository.GetHealth();
        }
    }
}
