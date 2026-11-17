using AddisEats.Api.Models;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Mappers;
    // static ምናደርገው Main ክሬት ሳናደርግ ከየትም ቦታ አክሰስ እንዲደረግ ነው

    public static class RestaurantMapper
    {
        public static RestaurantDTO ToDTO(this Restaurant restaurant){
            return new RestaurantDTO(
                restaurant.Id,
                restaurant.Name,
                restaurant.Address,
                restaurant.Phone,
                restaurant.IsActive
           );
        }
}

// RestaurantMapper restorantMapperObject = new();
// Restaurant Maki_Restorant_1 = Restaurant{Name="Maki", Id=1, Address="Piazza", Phone="09 11 12 13 14" IsActive = true};

// Maki_Restorant_1.Id => 1 ysetenal


//restorantMapperObject.toDto(Maki_Restorant)