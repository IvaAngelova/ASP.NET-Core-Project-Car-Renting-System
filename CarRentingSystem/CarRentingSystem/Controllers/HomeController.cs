﻿using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

using CarRentingSystem.Services.Cars;
using CarRentingSystem.Services.Cars.Models;

namespace CarRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService cars;
        private readonly IMemoryCache cache;

        public HomeController(ICarService cars, IMemoryCache cache)
        {
            this.cars = cars;
            this.cache = cache;
        }

        public IActionResult Index()
        {
            const string latestCarsCacheKey = "LatestCarsCacheKey";

            var latestCars = this.cache.Get<List<LatestCarServiceModel>>(latestCarsCacheKey);

            if (latestCars == null)
            {
                latestCars = this.cars
                    .Latest()
                    .ToList();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(15));

                this.cache.Set(latestCarsCacheKey, latestCars, cacheOptions);
            }
            return View(latestCars);
        }

        public IActionResult Error() => View();
    }
}
