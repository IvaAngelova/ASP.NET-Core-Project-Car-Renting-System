using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static CarRentingSystem.Data.DataConstants.Dealer;

namespace CarRentingSystem.Data.Models
{
    public class Dealer
    {
        public int Id { get; init; }

        [Requared]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Requared]
        [MaxLength(PhoneNumberMaxLenght)]
        public string PhoneNumber { get; set; }

        [Requared]
        public string UserId { get; set; }

        public IEnumerable<Car> Cars { get; init; }
            = new List<Car>();
    }
}
