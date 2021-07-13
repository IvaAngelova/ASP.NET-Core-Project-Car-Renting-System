namespace CarRentingSystem.Models.Cars
{
    public class CarListingViewModel
    {
        public int Id { get; init; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public string Category { get; init; }
    }
}
