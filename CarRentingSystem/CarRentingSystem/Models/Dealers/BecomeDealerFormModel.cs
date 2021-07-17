using System.ComponentModel.DataAnnotations;

using CarRentingSystem.Data.Models;

using static CarRentingSystem.Data.DataConstants.Dealer;

namespace CarRentingSystem.Models.Dealers
{
    public class BecomeDealerFormModel
    {
        [Requared]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Requared]
        [StringLength(PhoneNumberMaxLenght, MinimumLength = PhoneNumberMinLenght)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
