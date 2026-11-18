using AddisEats.Api.Service.RestaurantServices;
using AddisEats.Api.Mappers;
using AddisEats.Api.DTOs;
using Microsoft.AspNetCore.Mvc;


namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[Controller]")]

public class RestaurantController : ControllerBase
{

    private readonly IRestaurantServices _restaurantService;

    public RestaurantController(IRestaurantServices restaurantService)
    {
        _restaurantService = restaurantService;
    }

    [HttpGet("{id}")]
    public ActionResult<IEnumerable<IRestaurantServices>> GetRestaurantById(int id)
    {
        var restaurant = _restaurantService.GetById(id);

        if (restaurant == null)
        {
            return NotFound();
        }
        return Ok(restaurant);
    }

 [HttpGet()]
    public IActionResult GetAllRestaurant([FromQuery] RestaurantQuery query)
    {
        var restorantResult = _restaurantService.GetAll(query);

        return Ok(restorantResult);
    }

    [HttpGet("active")]
    public IActionResult GetAllActiveRestaurant()
    {
        var restaurants = _restaurantService.GetAllActive();

        return Ok(restaurants);
    }

}