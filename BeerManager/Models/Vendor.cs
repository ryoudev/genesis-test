namespace BeerManager.Models
{
	public class Vendor
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Stock> Stocks { get; set; }
        public List<Order> Orders { get; set; }
    }
}