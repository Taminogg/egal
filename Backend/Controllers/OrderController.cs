using TippsBackend.Services;

namespace TippsBackend.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderService _orderService;
    public OrderController(OrderService orderService) => _orderService = orderService;

    [HttpGet("GetAllOrders")]
    public List<OrderDto> GetAllOrders()
    {
        return _orderService.GetAllOrders();
    }

    [HttpGet("GetOrderWithId/{id}")]
    public OrderDto GetOrderWithId(int id)
    {
        return _orderService.GetOrderWithId(id);
    }

    [HttpPost("AddNewOrder")]
    public OrderDto AddOrder(AddOrderDto addOrderDto)
    {
        return _orderService.AddOrder(addOrderDto);
    }

    [HttpPut("EditOrder")]
    public OrderDto EditOrder(OrderDto editOrderDto)
    {
        return _orderService.EditOrder(editOrderDto);
    }

    [HttpDelete("DeleteOrder")]
    public OrderDto DeleteOrder(int id)
    {
        return _orderService.DeleteOrder(id);
    }
}
