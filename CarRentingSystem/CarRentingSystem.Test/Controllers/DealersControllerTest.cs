using System.Linq;

using Xunit;
using MyTested.AspNetCore.Mvc;

using CarRentingSystem.Controllers;
using CarRentingSystem.Models.Cars;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Models.Dealers;

using static CarRentingSystem.Test.Data.Cars;
using static CarRentingSystem.WebConstants.Cache;
using static CarRentingSystem.WebConstants;

namespace CarRentingSystem.Test.Controllers
{
    public class DealersControllerTest
    {
        [Fact]
        public void GetBecomeShouldBeAuthorizedUsersAndReturnView()
            => MyController<DealersController>
                .Instance()
                .Calling(c => c.Become())
                .ShouldHave()
                .ActionAttributes(attributes => attributes
                    .RestrictingForAuthorizedRequests())
                .AndAlso()
                .ShouldReturn()
                .View();

        [Theory]
        [InlineData("Dealer", "+359888888888")]
        public void PostBecomeShouldBeForAuthorizedUsersAndReturnRedirectWithValidModel(
            string dealerName, string phoneNumber)
            => MyController<DealersController>
                .Instance(instance => instance
                    .WithUser())
                .Calling(c => c.Become(new BecomeDealerFormModel
                {
                    Name = dealerName,
                    PhoneNumber = phoneNumber
                }))
                .ShouldHave()
                .ActionAttributes(attributes => attributes
                    .RestrictingForHttpMethod(HttpMethod.Post)
                    .RestrictingForAuthorizedRequests())
                .ValidModelState()
                .Data(data => data.WithSet<Dealer>(dealers =>dealers
                    .Any(d => d.Name == dealerName
                        && d.PhoneNumber == phoneNumber
                        && d.UserId == TestUser.Identifier)))
                .TempData(tempData => tempData
                    .ContainingEntryWithKey(GlobalMessageKey))
                .AndAlso()
                .ShouldReturn()
                .Redirect(redirect => redirect
                    .To<CarsController>
                    (c=>c.All(With.Any<AllCarsQueryModel>())));
    }
}
