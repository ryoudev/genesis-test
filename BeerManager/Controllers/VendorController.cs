using BeerManager.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeerManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : Controller
    {
        private readonly IVendorService _vendorService;

        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        // PUT api/vendors/{id}/addBeer
        [HttpPut("{id}/addBeer")]
        public IActionResult AddBeerToVendor(int vendorId, int beerId)
        {
            _vendorService.AddBeerToVendor(vendorId, beerId);
            return Ok($"Beer correctly added to the vendor");
        }

    }
}

