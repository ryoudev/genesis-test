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
            var vendor = _context.Vendors.FirstOrDefault(v => v.VendorId == vendorId);
            var beer = _context.Beers.FirstOrDefault(b => b.BeerId == beerId);

            if (vendor != null && beer != null)
            {
                vendor.Beers.Add(beer);
                _context.SaveChanges();              
            }
            else
            {
                throw new Exception("Vendor or beer not found");
            }
        }
    }
}

