using System;
namespace BeerManager.Models
{
	public class Vendor
	{
        public int VendorId { get; set; }
        public string Name { get; set; }
        public List<Beer> Beers { get; set; }
        public List<Stock> Stocks { get; set; }
    }
}