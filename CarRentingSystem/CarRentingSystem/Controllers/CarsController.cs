﻿using Microsoft.AspNetCore.Mvc;

using CarRentingSystem.Models.Cars;
using System.Collections.Generic;
using CarRentingSystem.Data;
using System.Linq;
using CarRentingSystem.Data.Models;

namespace CarRentingSystem.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarRentingDbContext context;

        public CarsController(CarRentingDbContext context)
        {
            this.context = context;
        }

        public IActionResult Add() => View(new AddCarFormModel
        {
            Categories = this.GetCarCategories()
        });

        [HttpPost]
        public IActionResult Add(AddCarFormModel car)
        {
            if (!this.context.Categories.Any(c=>c.Id == car.CategoryId))
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
                CategoryId = car.CategoryId
            };

            this.context.Cars.Add(carData);
            this.context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

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
