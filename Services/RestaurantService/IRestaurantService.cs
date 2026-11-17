using AddisEats.Api.Data;
using AddisEats.Api.Models;

 namespace  AddisEats.Api.Service.RestaurantServices;

public interface IRestaurantServices
{
    Restaurant? GetById(int id);
    List<Restaurant> GetAll(string? address, int page, int pageSize);
}