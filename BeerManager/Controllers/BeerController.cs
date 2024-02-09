using BeerManager.Models;
using BeerManager.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeerManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : Controller
    {
        private readonly IBeerService _beerService;

        public BeerController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpPost]
        public ActionResult<Beer> PostBeer(Beer beer)
        {
            _beerService.CreateBeer(beer);
            return Ok(beer);
        }

        [HttpGet("brasserie/{id}")]
        public ActionResult<IEnumerable<Beer>> GetBeersByBrasserie(int id)
        {
            var beers = _beerService.GetBeersByBrasserie(id);
            return Ok(beers);
        }

        [HttpGet("vendors/{id}")]
        public ActionResult<IEnumerable<Beer>> GetVendorsByBeer(int id)
        {
            var vendors = _beerService.GetVendorsByBeer(id);
            return Ok(vendors);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBeer(int id)
        {
            _beerService.DeleteBeer(id);
            return NoContent();
        }
    }
}

