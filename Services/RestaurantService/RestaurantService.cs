using AddisEats.Api.Data;
using AddisEats.Api.Models;

 namespace AddisEats.Api.Service.RestaurantServices;

 public class RestaurantService : IRestaurantServices
{

    private readonly List<Restaurant> allRestaurants = SeedData.Restaurants;

    public Restaurant? GetById(int id)
        {
            return allRestaurants.Where(r => r.Id == id).FirstOrDefault();
        }

    public List<Restaurant> GetAll(string? address, int page, int pageSize)
        {
            var Restaurants = allRestaurants
                .Where(r => address == null || r.Address == address)
                .OrderBy(r => r.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

                return Restaurants;
        }
}