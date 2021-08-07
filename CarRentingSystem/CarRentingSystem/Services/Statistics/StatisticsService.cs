using CarRentingSystem.Data;
using System.Linq;

namespace CarRentingSystem.Services.Statistics
{
    public class StatisticsService : IStatisticsService
    {
        private readonly CarRentingDbContext context;

        public StatisticsService(CarRentingDbContext context)
           => this.context = context;

        public StatisticsServiceModel Total()
        {
            var totalCars = this.context
                   .Cars
                   .Count(c => c.IsPublic);

            var totalUsers = this.context
                .Users
                .Count();

            return new StatisticsServiceModel
            {
                TotalCars = totalCars,
                TotalUsers = totalUsers
            };
        }
    }
}
