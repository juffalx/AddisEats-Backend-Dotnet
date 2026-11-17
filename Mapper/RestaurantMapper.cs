using AddisEats.Api.Models;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Mappers;
    // static ምናደርገው Main ክሬት ሳናደርግ ከየትም ቦታ አክሰስ እንዲደረግ ነው
    public static class RestaurantMapper
    {
        public static RestaurantDTO ToDTO(Restaurant restaurant){
            return new RestaurantDTO(
                restaurant.Id,
                restaurant.Name,
                restaurant.Address,
                restaurant.Phone,
                restaurant.IsActive 
            );
        }
}