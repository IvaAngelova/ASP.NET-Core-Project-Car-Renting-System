using System.Linq;
using Xunit;

using Microsoft.AspNetCore.Mvc;

using CarRentingSystem.Test.Mocks;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Controllers;
using CarRentingSystem.Models.Home;
using CarRentingSystem.Services.Cars;
using CarRentingSystem.Services.Statistics;

using MyTested.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarRentingSystem.Test.Controller
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexshoulReturnViewWithCorrectModelAndData()
            => MyMvc
            .Pipeline()
            .ShouldMap("/")
            .To<HomeController>(c=>c.Index())
            .Which(controller => controller
                .WithData(GetCars()))
            .ShouldReturn()
            .View(view => view
                .WithModelOfType<IndexViewModel>()
            .Passing(m=>m.Cars.Count.Equals(3)));

        [Fact]
        public void IndexShouldReturnViewWithCorrectModel()
        {
            //Arrange
            var data = DatabaseMock.Instance;
            var mapper = MapperMock.Instance;

            var cars = GetCars();

            data.Cars.AddRange(cars);

            data.Users.Add(new User());

            data.SaveChanges();

            var carService = new CarService(data, mapper);
            var statisticsService = new StatisticsService(data);

            var homeController = new HomeController(carService, statisticsService);

            //Act
            var result = homeController.Index();

            //Assert
            Assert.NotNull(result);

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = viewResult.Model;

            var indexViewModel = Assert.IsType<IndexViewModel>(model);

            Assert.Equal(3, indexViewModel.Cars.Count);
            Assert.Equal(10, indexViewModel.TotalCars);
            Assert.Equal(1, indexViewModel.TotalUsers);
        }

        [Fact]
        public void ErrorShoulReturnViec()
        {
            //Arrange
            var homeController = new HomeController(null, null);

            //Act
            var result = homeController.Error();

            //Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        private static IEnumerable<Car> GetCars()
            => Enumerable.Range(0, 10).Select(i => new Car());
    }
}
