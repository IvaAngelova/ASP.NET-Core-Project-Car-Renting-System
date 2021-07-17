using System.Linq;

using CarRentingSystem.Data;
using CarRentingSystem.Data.Models;
using CarRentingSystem.Infrastructure;
using CarRentingSystem.Models.Dealers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CarRentingSystem.Controllers
{
    public class DealersController : Controller
    {
        private readonly CarRentingDbContext context;

        public DealersController(CarRentingDbContext context)
        {
            this.context = context;
        }

        [Authorize]
        public IActionResult Become() => View();

        [HttpPost]
        [Authorize]
        public IActionResult Become(BecomeDealerFormModel dealer)
        {
            var userId = this.User.GetId();

            var userIsAlreadyDealer = this.context
                .Dealers
                .Any(d => d.UserId == userId);

            if (userIsAlreadyDealer)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(dealer);
            }

            var dealerData = new Dealer
            {
                Name = dealer.Name,
                PhoneNumber = dealer.PhoneNumber,
                UserId = userId
            };

            this.context.Dealers.Add(dealerData);
            this.context.SaveChanges();

            return RedirectToAction("All", "Cars");
        }
    }
}
