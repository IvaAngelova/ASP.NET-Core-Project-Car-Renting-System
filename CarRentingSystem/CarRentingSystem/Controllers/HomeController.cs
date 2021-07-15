using System.Linq;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using CarRentingSystem.Data;
using CarRentingSystem.Models;
using CarRentingSystem.Models.Home;

namespace CarRentingSystem.Controllers
{
    public class HomeController : Controller
    {

        private readonly CarRentingDbContext context;

        public HomeController(CarRentingDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var totalCars = this.context
                .Cars
                .Count();

            var cars = this.context
                .Cars
                .OrderByDescending(c => c.Id)
                .Select(c => new CarIndexViewModel
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    Year = c.Year,
                    ImageUrl = c.ImageUrl
                })
                .Take(3)
                .ToList();

            return View(new IndexViewModel
            {
                TotalCars = totalCars,
                Cars = cars
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
