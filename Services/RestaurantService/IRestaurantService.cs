using AddisEats.Api.DTOs;
using AddisEats.Api.Models;

 namespace  AddisEats.Api.Service.RestaurantServices;

public interface IRestaurantServices
{
    Restaurant? GetById(int id);
    PaginatedResultDTO<RestaurantDTO> GetAll(RestaurantQuery query);
    List<RestaurantDTO> GetAllActive();
}


