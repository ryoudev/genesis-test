using BeerManager.Models;
using BeerManager.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace BeerManager.Services
{
	public class VendorService: IVendorService
	{
        private readonly BeerManagerContext _context;

        public VendorService(BeerManagerContext context)
		{
            _context = context;
        }

        public void AddBeerToVendor(int vendorId, int beerId)
        {
            var beer = _context.Beers.FirstOrDefault(b => b.Id == beerId);
            var vendor = _context.Vendors.FirstOrDefault(v => v.Id == vendorId);

            if(beer == null || vendor == null)
            {
                throw new Exception("Beer or vendor doesn't exist");
            }

            if (vendor.Stocks.Any(s => s.BeerId == beerId))
            {
                throw new Exception("Beer is already sold by this vendor");
            }

            var beerStock = new Stock
            {
                BeerId = beerId,
                Quantity = 0 
            };

            vendor.Stocks.Add(beerStock);

            _context.SaveChanges();
        }
    }
}

