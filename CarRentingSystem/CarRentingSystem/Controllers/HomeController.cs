using System.Linq;

using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using CarRentingSystem.Data;
using CarRentingSystem.Models.Home;
using CarRentingSystem.Services.Statistics;
using AutoMapper.QueryableExtensions;

namespace CarRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStatisticsService statistics;
        private readonly CarRentingDbContext context;
        private readonly IMapper mapper;

        public HomeController(IStatisticsService statistics, 
            CarRentingDbContext context, IMapper mapper)
        {
            this.statistics = statistics;
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var cars = this.context
                .Cars
                .OrderByDescending(c => c.Id)
                .ProjectTo<CarIndexViewModel>(this.mapper.ConfigurationProvider)
                .Take(3)
                .ToList();

            var totalStatistics = this.statistics.Total();

            return View(new IndexViewModel
            {
                TotalCars = totalStatistics.TotalCars,
                TotalUsers = totalStatistics.TotalUsers,
                Cars = cars
            });
        }

        public IActionResult Error() => View();
    }
}
