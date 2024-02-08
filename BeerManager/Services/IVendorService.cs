using BeerManager.Models;

namespace BeerManager.Services
{
	public interface IVendorService
	{
        void AddBeerToVendor(int vendorId, int beerId);
    }
}

