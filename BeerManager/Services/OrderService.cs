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

        public void CreateOrder(int beerId, int quantity)
        {
            
        }
    }
}

