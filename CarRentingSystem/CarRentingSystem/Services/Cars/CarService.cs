using System.Linq;
using System.Collections.Generic;

using CarRentingSystem.Data;
using CarRentingSystem.Models;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Services.Cars.Models;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace CarRentingSystem.Services.Cars
{
    public class CarService : ICarService
    {
        private readonly CarRentingDbContext context;
        private readonly IMapper mapper;

        public CarService(CarRentingDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

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

            var cars = GetCars(carQuery
                .Skip((currentPage - 1) * carsPerPage)
                .Take(carsPerPage));

            return new CarQueryServiceModel
            {
                TotalCars = totalCars,
                CurrentPage = currentPage,
                CarsPerPage = carsPerPage,
                Cars = cars
            };
        }

        public CarDetailsServiceModel Details(int carId)
            => this.context
                   .Cars
                   .Where(c => c.Id == carId)
                   .ProjectTo<CarDetailsServiceModel>(this.mapper.ConfigurationProvider)
                   .FirstOrDefault();

        public int Create(string brand, string model,
                string description, string imageUrl,
                int year, int categoryId, int dealerId)
        {
            var carData = new Car
            {
                Brand = brand,
                Model = model,
                Description = description,
                ImageUrl = imageUrl,
                Year = year,
                CategoryId = categoryId,
                DealerId = dealerId
            };

            this.context.Cars.Add(carData);
            this.context.SaveChanges();

            return carData.Id;
        }

        public bool Edit(int carId, string brand, string model,
            string description, string imageUrl, int year,
            int categoryId)
        {
            var carData = this.context.Cars.Find(carId);

            if (carData == null)
            {
                return false;
            }

            carData.Brand = brand;
            carData.Model = model;
            carData.Description = description;
            carData.ImageUrl = imageUrl;
            carData.Year = year;
            carData.CategoryId = categoryId;

            this.context.SaveChanges();

            return true;
        }

        public IEnumerable<CarServiceModel> ByUser(string userId)
            => GetCars(this.context
                .Cars
                .Where(c => c.Dealer.UserId == userId));

        public bool IsByDealer(int carId, int dealerId)
            => this.context
                   .Cars
                   .Any(c => c.Id == carId && c.DealerId == dealerId);

        public IEnumerable<string> AllBrands()
           => this.context
                  .Cars
                  .Select(br => br.Brand)
                  .OrderBy(br => br)
                  .Distinct()
                  .ToArray();

        public IEnumerable<CarCategoryServiceModel> AllCategories()
        => this.context
                    .Categories
                    .Select(c => new CarCategoryServiceModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    })
                    .ToList();

        public bool CategoryExists(int categoryId)
            => this.context
                   .Categories
                   .Any(c => c.Id == categoryId);

        private static IEnumerable<CarServiceModel> GetCars(IQueryable<Car> carsQuery)
            => carsQuery.Select(c => new CarServiceModel
            {
                Id = c.Id,
                Brand = c.Brand,
                Model = c.Model,
                Year = c.Year,
                ImageUrl = c.ImageUrl,
                CategoryName = c.Category.Name
            })
            .ToList();
    }
}
