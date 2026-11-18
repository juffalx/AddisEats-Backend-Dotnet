namespace AddisEats.Api.DTOs;

public record CreatOrderDTO(
    int Id,
    int RestaurantId ,
    string CustomerName,
    int MenuItemId,
    string DeliveryAddress,
    string CustomerPhone,
    int Quantity,
    decimal TotalAmount
);