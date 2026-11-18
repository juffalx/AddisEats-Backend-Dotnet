using AddisEats.Api.DTOs;
using AddisEats.Api.Models;

namespace AddisEats.Api.Services.OrderService;

public class OrderService : IOrderService
{
    private static readonly List<Order> _order = new List<Order>();

    private static int _nextId = 1;
    public Order? GetById(int id)
    {
        var result =  _order.FirstOrDefault(o => o.Id == id);
        return result;
    }


    public Order CreateOrder(CreatOrderDTO createDTO)
{
    var order = new Order
    {
        Id = _nextId++,
        RestaurantId = createDTO.RestaurantId,
        MenuItemId = createDTO.MenuItemId,
        CustomerName = createDTO.CustomerName,
        DeliveryAddress = createDTO.DeliveryAddress,
        CustomerPhone = createDTO.CustomerPhone,
        Quantity = createDTO.Quantity,
        TotalAmount = createDTO.TotalAmount
    };

    _order.Add(order);
    return order;
}
}