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
            var beer = _context.Beers.FirstOrDefault(x => x.BeerId == beerId);
            if(beer != null)
            {
                _context.Beers.Remove(beer);
            }
        }

        public List<Beer> GetBeersByBrasserie(int brasserieId)
        {
            return _context.Beers.Where(x => x.BrasserieId == brasserieId).ToList();
        }

        public List<Vendor> GetVendorsByBeer(int beerId)
        {
            var beer = _context.Beers.FirstOrDefault(x => x.BeerId == beerId);

            if(beer != null)
            {
                return beer.Vendors.ToList();
            }

            return null;
        }
    }
}

