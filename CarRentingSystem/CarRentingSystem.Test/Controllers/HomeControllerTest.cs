using System;
using System.Collections.Generic;

using Xunit;
using FluentAssertions;
using MyTested.AspNetCore.Mvc;

using CarRentingSystem.Controllers;
using CarRentingSystem.Services.Cars.Models;

using static CarRentingSystem.Test.Data.Cars;
using static CarRentingSystem.WebConstants.Cache;

namespace CarRentingSystem.Test.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexActionShouldReturnCorrectViewWithModel()
            => MyController<HomeController>
                .Instance(instance => instance
                    .WithData(TenPublicCars()))
                .Calling(c=>c.Index())
                .ShouldHave()
                .MemoryCache(cache => cache
                    .ContainingEntry(entry => entry
                        .WithKey(LatestCarsCacheKey)
                        .WithAbsoluteExpirationRelativeToNow(TimeSpan.FromMinutes(15))
                        .WithValueOfType<List<LatestCarServiceModel>>()))
                .AndAlso()
                .ShouldReturn()
                .View(view => view
                    .WithModelOfType<List<LatestCarServiceModel>>()
                    .Passing(m => m.Should().HaveCount(3)));

        [Fact]
        public void ErrorShouldReturnView()
            => MyController<HomeController>
                .Instance()
                .Calling(c=>c.Error())
                .ShouldReturn()
                .View();
    }
}
