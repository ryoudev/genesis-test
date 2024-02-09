using System;
using BeerManager.Models;
using BeerManager.Models.Context;

namespace BeerManager.Services
{
	public class BeerService: IBeerService
	{
        private readonly BeerManagerContext _context;

        public BeerService(BeerManagerContext context)
		{
            _context = context;
		}

        public Beer CreateBeer(Beer newBeer)
        {
            _context.Beers.Add(newBeer);
            _context.SaveChanges();
            return newBeer;
        }

        public void DeleteBeer(int beerId)
        {
            var beerToDelete = _context.Beers.FirstOrDefault(b => b.Id == beerId);

            if (beerToDelete != null)
            {
                _context.Beers.Remove(beerToDelete);
                _context.SaveChanges();
            }
        }

        public List<Beer> GetBeersByBrasserie(int brasserieId)
        {
            return _context.Beers.Where(b => b.BrasserieId == brasserieId).ToList();
        }

        public List<string> GetVendorsByBeer(int beerId)
        {
            var vendors = _context.Vendors.Where(v => v.Stocks.Any(b => b.BeerId == beerId))
                                            .Select(v => v.Name)
                                            .ToList();
            return vendors;
        }
    }
}