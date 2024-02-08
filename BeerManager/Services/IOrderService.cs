namespace BeerManager.Services
{
	public interface IOrderService
	{
		void CreateOrder(int beerId, int quantity);
	}
}

