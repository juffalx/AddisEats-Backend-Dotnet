// using AddisEats.Api.Models;

// namespace AddisEats.Api.Service.RestaurantServices;
// public interface IRestaurantService
// {
//  Restaurant? GetById(int id);
//  List<Restaurant> GetAll(string? address, int page, int pageSize); 
// }

// public class Restaurant? GetById(int id){
//     return allRestaurants.Where(r => r.Id == id).FirstOrDefault();
// }

// public List<Restaurant> GetAll(string? address, int page, int pageSize)
// {
//     var Restaurants = allRestaurants
//     .Where(r => address == null || r.Address == adress)
//     .OrderBy(r => r.Name)
//     .Skip((page-1) * pagesize)
//     .Take(pageSize)
//     .ToList();

//     return restaurants;

// }