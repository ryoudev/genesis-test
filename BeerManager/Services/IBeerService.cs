using System;
using BeerManager.Models;

namespace BeerManager.Services
{
	public interface IBeerService
    {
        Beer CreateBeer(Beer newBeer);
        void DeleteBeer(int beerId);
        List<Beer> GetBeersByBrasserie(int brasserieId);
        List<string> GetVendorsByBeer(int beerId);
    }
}

