namespace CarRentingSystem.Services.Cars.Models
{
    public class CarServiceModel : ICarModel
    {
        public int Id { get; init; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public string CategoryName { get; init; }

        public bool IsPublic { get; init; }
    }
}
