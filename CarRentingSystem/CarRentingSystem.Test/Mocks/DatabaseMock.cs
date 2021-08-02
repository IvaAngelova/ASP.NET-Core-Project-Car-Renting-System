using CarRentingSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarRentingSystem.Test.Mocks
{
   public static class DatabaseMock
    {
        public static CarRentingDbContext Instance
        {
            get
            {
                var dbContextOption = new DbContextOptionsBuilder<CarRentingDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;

                return new CarRentingDbContext(dbContextOption);
            }
        } 
    }
}
