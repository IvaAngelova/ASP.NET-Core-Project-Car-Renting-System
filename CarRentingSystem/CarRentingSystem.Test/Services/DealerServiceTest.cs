using Xunit;

using CarRentingSystem.Test.Mocks;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Services.Dealers;
using CarRentingSystem.Data;

namespace CarRentingSystem.Test.Services
{
    public class DealerServiceTest
    {
        private const string userId = "TestUserId";

        [Fact]
        public void IsDealerShouldReturnTrueWhenUserIsDealer()
        {
            //Arrange
            var delaerService = GetDealerService();

            //Act
            var result = delaerService.IsDealer(userId);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsDealerShouldReturnFalseWhenUserIsNotDealer()
        {
            //Arrange
            var delaerService = GetDealerService();

            //Act
            var result = delaerService.IsDealer("AnotherUserId");

            //Assert
            Assert.False(result);
        }

        private static IDealerService GetDealerService()
        {
            var data = DatabaseMock.Instance;

            data.Dealers.Add(new Dealer
            {
                UserId = userId
            });

            data.SaveChanges();

            return new DealerService(data);
        }
    }
}
