using Xunit;
using MyTested.AspNetCore.Mvc;

using CarRentingSystem.Controllers;

using static CarRentingSystem.Test.Data.Cars;
using static CarRentingSystem.WebConstants.Cache;

namespace CarRentingSystem.Test.Routing
{
    public class HomeControllerTest
    {
        [Fact]
        public void GetIndexRouteShoulBeMapped()
            => MyRouting
                .Configuration()
                .ShouldMap("/Home/Index")
                .To<HomeController>(c => c.Index());

        [Fact]
        public void GetErrorRouteShoulBeMapped()
            => MyRouting
                .Configuration()
                .ShouldMap("/Home/Error")
                .To<HomeController>(c => c.Error());
    }
}
