using System.Linq;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using CarRentingSystem.Data;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Models.Cars;
using CarRentingSystem.Services.Cars;
using CarRentingSystem.Infrastructure;

namespace CarRentingSystem.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarService cars;
        private readonly CarRentingDbContext context;

        public CarsController(ICarService cars, CarRentingDbContext context)
        {
            this.cars = cars;
            this.context = context;
        }

        [Authorize]
        public IActionResult Add()
        {
            if (!this.UserIsDealer())
            {
                return RedirectToAction(nameof(DealersController.Become), "Dealers");
            }

            return View(new AddCarFormModel
            {
                Categories = this.GetCarCategories()
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(AddCarFormModel car)
        {
            var dealerId = this.context
                  .Dealers
                  .Where(d => d.UserId == this.User.GetId())
                  .Select(d => d.Id)
                  .FirstOrDefault();

            if (dealerId == 0)
            {
                return RedirectToAction(nameof(DealersController.Become), "Dealers");
            }

            if (!this.context.Categories.Any(c => c.Id == car.CategoryId))
            {
                this.ModelState.AddModelError(nameof(car.CategoryId), "Category does not exist.");
            }

            if (!ModelState.IsValid)
            {
                car.Categories = this.GetCarCategories();

                return View(car);
            }

            var carData = new Car
            {
                Brand = car.Brand,
                Model = car.Model,
                Description = car.Description,
                ImageUrl = car.ImageUrl,
                Year = car.Year,
                CategoryId = car.CategoryId,
                DealerId = dealerId
            };

            this.context.Cars.Add(carData);
            this.context.SaveChanges();

            return RedirectToAction(nameof(All));
        }

        public IActionResult All([FromQuery] AllCarsQueryModel query)
        {
            var queryResult = this.cars.All(
               query.Brand,
               query.SearchTerm,
               query.Sorting,
               query.CurrentPage,
               AllCarsQueryModel.CarsPerPage);

            var carBrands = this.cars.AllCarBrands();

            query.Brands = carBrands;
            query.TotalCars = queryResult.TotalCars;
            query.Cars = queryResult.Cars;

            return View(query);
        }

        private bool UserIsDealer()
            => this.context
                .Dealers
                .Any(d => d.UserId == this.User.GetId());

        private IEnumerable<CarCategoryViewModel> GetCarCategories()
            => this.context
                    .Categories
                    .Select(c => new CarCategoryViewModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    })
                    .ToList();
    }
}
