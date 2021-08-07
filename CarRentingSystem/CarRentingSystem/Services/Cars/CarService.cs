using System.Linq;
using System.Collections.Generic;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using CarRentingSystem.Data;
using CarRentingSystem.Models;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Services.Cars.Models;

namespace CarRentingSystem.Services.Cars
{
    public class CarService : ICarService
    {
        private readonly CarRentingDbContext context;
        private readonly IConfigurationProvider mapper;

        public CarService(CarRentingDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper.ConfigurationProvider;
        }

        public CarQueryServiceModel All(
            string brand = null,
            string searchTerm = null,
            CarSorting sorting = CarSorting.DateCreated,
            int currentPage = 1,
            int carsPerPage = int.MaxValue,
            bool publicOnly = true)
        {
            var carQuery = this.context
                .Cars
                .Where(c => !publicOnly || c.IsPublic);

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

        public IEnumerable<LatestCarServiceModel> Latest()
            => this.context
                .Cars
                .Where(c=>c.IsPublic)
                .OrderByDescending(c => c.Id)
                .ProjectTo<LatestCarServiceModel>(this.mapper)
                .Take(3)
                .ToList();

        public CarDetailsServiceModel Details(int carId)
            => this.context
                   .Cars
                   .Where(c => c.Id == carId)
                   .ProjectTo<CarDetailsServiceModel>(this.mapper)
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
                DealerId = dealerId,
                IsPublic = false
            };

            this.context.Cars.Add(carData);
            this.context.SaveChanges();

            return carData.Id;
        }

        public bool Edit(int carId, string brand, string model,
            string description, string imageUrl, int year,
            int categoryId, bool isPublic)
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
            carData.IsPublic = isPublic;

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
                    .ProjectTo<CarCategoryServiceModel>(this.mapper)
                    .ToList();

        public bool CategoryExists(int categoryId)
            => this.context
                   .Categories
                   .Any(c => c.Id == categoryId);

        private IEnumerable<CarServiceModel> GetCars(IQueryable<Car> carsQuery)
            => carsQuery
                .ProjectTo<CarServiceModel>(this.mapper)
                .ToList();

        public void ChangeVisibility(int carId)
        {
            var car = this.context.Cars.Find(carId);

            car.IsPublic = !car.IsPublic;

            this.context.SaveChanges();
        }
    }
}
