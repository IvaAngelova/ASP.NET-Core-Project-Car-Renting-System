using System.Linq;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using CarRentingSystem.Data;
using CarRentingSystem.Models.Cars;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Infrastructure;

namespace CarRentingSystem.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarRentingDbContext context;

        public CarsController(CarRentingDbContext context)
        {
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

        public IActionResult All([FromQuery]AllCarsQueryModel query)
        {
            var carQuery = this.context
                .Cars
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.Brand))
            {
                carQuery = carQuery
                    .Where(c => c.Brand ==query.Brand);
            }

            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                carQuery = carQuery
                    .Where(c =>
                    (c.Brand + " " + c.Model).ToLower().Contains(query.SearchTerm.ToLower())
                    || c.Description.ToLower().Contains(query.SearchTerm.ToLower()));
            }

            carQuery = query.Sorting switch
            {
                CarSorting.Year => carQuery
                                            .OrderByDescending(c=>c.Year),
                CarSorting.BrandAndModel => carQuery
                                            .OrderByDescending(c=>c.Brand)
                                            .ThenBy(c=>c.Model),
                CarSorting.DateCreated or _=> carQuery
                                            .OrderByDescending(c=>c.Id)
            };

            var totalCars = carQuery.Count();

            var cars = carQuery
                .Skip((query.CurrentPage - 1) * AllCarsQueryModel.CarsPerPage)
                .Take(AllCarsQueryModel.CarsPerPage)
                .Select(c => new CarListingViewModel
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    Year = c.Year,
                    ImageUrl = c.ImageUrl,
                    Category = c.Category.Name
                })
                .ToList();

            var carBrands = this.context
                .Cars
                .Select(br => br.Brand)
                .OrderBy(br => br)
                .Distinct()
                .ToArray();

            query.TotalCars = totalCars;
            query.Brands = carBrands;
            query.Cars = cars;

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
