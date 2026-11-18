using AddisEats.Api.Data;
using AddisEats.Api.DTOs;
using AddisEats.Api.Mappers;
using AddisEats.Api.Models;

 namespace AddisEats.Api.Service.RestaurantServices;

 public class RestaurantService : IRestaurantServices
{

    private readonly List<Restaurant> allRestaurants = SeedData.Restaurants;

    public Restaurant? GetById(int id)
        {
            return allRestaurants.Where(r => r.Id == id).FirstOrDefault();
        }

    public PaginatedResultDTO<RestaurantDTO> GetAll(RestaurantQuery query)
        {
            var Restaurants = allRestaurants
                .Where(r => query.Address == null || r.Address == query.Address)
                .Where(r => query.Name == null || r.Name == query.Name)
                .Where(r => query.IsActive == null || r.IsActive == query.IsActive)
                .OrderBy(r => r.Name)
                .ToList();

            var TotalCount = Restaurants.Count();

            var ForRestaurant = Restaurants
            .Skip((query.Page - 1) * query.PageSize)
            .Take(query.PageSize)
            .ToList();
            
            PaginatedResultDTO<RestaurantDTO> resultDTO = new PaginatedResultDTO<RestaurantDTO>()
            {
                TotalCount = TotalCount,
                PageSize = query.PageSize,
                Page = query.Page,
                Data = ForRestaurant.Select(r => r.ToDTO()).ToList()
            };

            return resultDTO; 
        }

    public List<RestaurantDTO> GetAllActive()
    {
            var Restaurants = allRestaurants
                .Where(r => r.IsActive == true).OrderBy(r => r.Name)
                .ToList();
            
                var ReturnGetAllActiveWithDTOs=  Restaurants.Select(r => r.ToDTO()).ToList();
                return ReturnGetAllActiveWithDTOs;
        }

}