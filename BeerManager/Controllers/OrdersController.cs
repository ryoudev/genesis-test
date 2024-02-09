using BeerManager.Models;
using BeerManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace BeerManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // POST api/orders/quote
        [HttpPost("quote")]
        public ActionResult<decimal> AskForQuote(List<Order> orders, int vendorId)
        {
            try
            {
                var (totalPrice, summary) = _orderService.AskQuote(orders, vendorId);
                return Ok(new { Price = totalPrice, Summary = summary });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}

