using System.Linq;

using CarRentingSystem.Data;

namespace CarRentingSystem.Services.Dealers
{
    public class DealerService : IDealerService
    {
        private readonly CarRentingDbContext context;

        public DealerService(CarRentingDbContext context)
            => this.context = context;

        public int IdByUser(string userId)
            => this.context
                  .Dealers
                  .Where(d => d.UserId == userId)
                  .Select(d => d.Id)
                  .FirstOrDefault();

        public bool IsDealer(string userId)
            => this.context
                   .Dealers
                   .Any(d => d.UserId == userId);
    }
}
