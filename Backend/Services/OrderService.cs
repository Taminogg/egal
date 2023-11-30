namespace TippsBackend.Services;

public class OrderService
{
    private readonly ContainerToolDBContext _db;

    public OrderService(ContainerToolDBContext db) => _db = db;

    public List<OrderDto> GetAllOrders()
    {
        return _db.Orders
            .Select(x => new OrderDto().CopyFrom(x))
            .ToList();
    }

    public OrderDto GetOrderWithId(int id)
    {
        Order order = _db.Orders
            .Single(x => x.Id == id);

        return new OrderDto().CopyFrom(order);
    }

    public OrderDto AddOrder(AddOrderDto addOrderDto)
    {
        var order = new Order().CopyFrom(addOrderDto);

        _db.Orders.Add(order);
        _db.SaveChanges();

        return new OrderDto().CopyFrom(order);
    }

    public OrderDto EditOrder(OrderDto editOrderDto)
    {
        var checklist = _db.Checklists.Single(x => x.Id == editOrderDto.ChecklistId);
        var cs = _db.Csinquiries.Single(x => x.Id == editOrderDto.Csid);
        var tl = _db.Tlinquiries.Single(x => x.Id == editOrderDto.Tlid);

        var order = _db.Orders.Single(x => x.Id == editOrderDto.Id);
        order.Approved = editOrderDto.Approved;
        order.Checklist = checklist;
        order.LastUpdated = editOrderDto.LastUpdated;
        order.ChecklistId = editOrderDto.ChecklistId;
        order.Csid = editOrderDto.Csid;
        order.Amount = editOrderDto.Amount;
        order.CreatedBy = editOrderDto.CreatedBy;
        order.CustomerName = editOrderDto.CustomerName;
        order.Cs = cs;
        order.Status = editOrderDto.Status;
        order.Tl = tl;
        order.Tlid = editOrderDto.Tlid;
        _db.SaveChanges();

        return new OrderDto().CopyFrom(order);
    }

    public OrderDto DeleteOrder(int id)
    {
        var order = _db.Orders.Single(x=> x.Id == id);

        _db.Orders.Remove(order);
        _db.SaveChanges();

        return new OrderDto().CopyFrom(order);
    }
}
