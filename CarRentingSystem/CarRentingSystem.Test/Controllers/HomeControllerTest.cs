using System.Linq;
using System.Collections.Generic;

using Xunit;
using MyTested.AspNetCore.Mvc;
using FluentAssertions;

using Microsoft.AspNetCore.Mvc;

using CarRentingSystem.Test.Mocks;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Controllers;
using CarRentingSystem.Services.Cars;
using CarRentingSystem.Services.Statistics;
using CarRentingSystem.Services.Cars.Models;

namespace CarRentingSystem.Test.Controller
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexShouldReturnViewWithCorrectModelAndData()
            => MyMvc
                .Pipeline()
                .ShouldMap("/")
                .To<HomeController>(c => c.Index())
                .Which(controller => controller
                    .WithData(GetCars()))
                .ShouldReturn()
                .View(view => view
                    .WithModelOfType<List<LatestCarServiceModel>>()
                    .Passing(m => m.Should().HaveCount(3)));

        private static IEnumerable<Car> GetCars()
            => Enumerable.Range(0, 10).Select(i => new Car());
    }
}
