using BeerManager.Models;

namespace BeerManager.Services
{
	public interface IOrderService
	{
        (decimal totalPrice, string summary) AskQuote(List<Order> orders, int vendorId);
	}
}

