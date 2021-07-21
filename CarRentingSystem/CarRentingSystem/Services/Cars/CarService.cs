using System.Collections.Generic;
using System.Linq;

using CarRentingSystem.Data;
using CarRentingSystem.Models;

namespace CarRentingSystem.Services.Cars
{
    public class CarService : ICarService
    {
        private readonly CarRentingDbContext context;

        public CarService(CarRentingDbContext context) => this.context = context;

        public CarQueryServiceModel All(
            string brand,
            string searchTerm,
            CarSorting sorting,
            int currentPage,
            int carsPerPage)
        {
            var carQuery = this.context
                .Cars
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(brand))
            {
                carQuery = carQuery
                    .Where(c => c.Brand == brand);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                carQuery = carQuery
                    .Where(c =>
                    (c.Brand + " " + c.Model).ToLower().Contains(searchTerm.ToLower())
                    || c.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            carQuery = sorting switch
            {
                CarSorting.Year => carQuery
                                            .OrderByDescending(c => c.Year),
                CarSorting.BrandAndModel => carQuery
                                            .OrderByDescending(c => c.Brand)
                                            .ThenBy(c => c.Model),
                CarSorting.DateCreated or _ => carQuery
                                            .OrderByDescending(c => c.Id)
            };

            var totalCars = carQuery.Count();

            var cars = carQuery
                .Skip((currentPage - 1) * carsPerPage)
                .Take(carsPerPage)
                .Select(c => new CarServiceModel
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    Year = c.Year,
                    ImageUrl = c.ImageUrl,
                    Category = c.Category.Name
                })
                .ToList();

            return new CarQueryServiceModel
            {
                TotalCars = totalCars,
                CurrentPage = currentPage,
                CarsPerPage = carsPerPage,
                Cars = cars
            };
        }

        public IEnumerable<string> AllCarBrands() => 
            this.context
                .Cars
                .Select(br => br.Brand)
                .OrderBy(br => br)
                .Distinct()
                .ToArray();
    }
}
