namespace BeerManager.Models
{
    public class Stock
	{
		public int Id { get; set; }
		public int BeerId { get; set; }
		public Beer Beer { get; set; }
		public int Quantity { get; set; }
	}
}