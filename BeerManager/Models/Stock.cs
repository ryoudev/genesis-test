using System;
namespace BeerManager.Models
{
	public class Stock
	{
		public int StockId { get; set; }
		public int VendorId { get; set; }
		public int BeerId { get; set; }
		public int StockQuantity { get; set; }
		public Beer Beer { get; set; }
		public Vendor Vendor { get; set; }
	}
}