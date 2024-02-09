using System.Text;
using BeerManager.Models;
using BeerManager.Models.Context;

namespace BeerManager.Services
{
	public class OrderService: IOrderService
	{
        private readonly BeerManagerContext _context;

        public OrderService(BeerManagerContext context)
		{
            _context = context;
        }

        public (decimal totalPrice, string summary) AskQuote(List<Order> orders, int vendorId)
        {
            var vendor = _context.Vendors.FirstOrDefault(v => v.Id == vendorId);
            decimal totalPrice = 0;

            //Check if order is not empty
            if (orders == null || !orders.Any())
            {
                throw new ArgumentException("The order cannot be empty");
            }

            //Check if vendor exist
            if(vendor == null)
            {
                throw new ArgumentException("The vendor doesn't exist");
            }          

            foreach (var order in orders)
            {
                //Check if the beer is sell by the vendor
                var beerStock = vendor.Stocks.FirstOrDefault(s => s.BeerId == order.BeerId);

                if (beerStock == null || beerStock.Quantity < order.Quantity)
                {
                    throw new ArgumentException($"The beer {order.Beer.Name} is not sold by the vendor or is out of stock");
                }

                //Define total price for the order
                totalPrice += order.TotalPrice;
            }

            //Apply discount 10% or 20% accroding to the numbers of beers ordered
            if (orders.Sum(c => c.Quantity) > 20)
            {
                totalPrice *= (decimal)0.8;
            }
            else if (orders.Sum(c => c.Quantity) > 10)
            {
                totalPrice *= (decimal)0.9;
            }

            var summary = CreateSummary(orders, totalPrice);

            return (totalPrice, summary);
        }

        //Method to create a string with different lines of the order
        private string CreateSummary(List<Order> orders, decimal totalPrice)
        {
            var summary = new StringBuilder();
            summary.AppendLine("Summary of the order :");

            foreach (var order in orders)
            {
                summary.AppendLine($"Quantity: {order.Quantity} x {order.Beer.Name} = {order.TotalPrice} euros");
            }

            summary.AppendLine($"Total price of the order : {totalPrice} euros");

            return summary.ToString();
        }
    }
}

