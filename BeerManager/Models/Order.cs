namespace BeerManager.Models
{
	public class Order
	{
        public int Id { get; set; }
        public int BeerId { get; set; }
        public Beer Beer { get; set; }
        public int VendorId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}