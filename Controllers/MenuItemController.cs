using AddisEats.Api.Models;
using Microsoft.AspNetCore.Mvc;
namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[Controller]")]

public class MenuItemController : ControllerBase
{
    List<MenuItem> menuItems = new List<MenuItem>
        {
    new MenuItem { Id = 1, Name = "Cheeseburger", Category = "Main Course", Price= 10.5m},
    new MenuItem { Id = 2, Name = "Caesar Salad", Category = "Appetizer", Price= 20.5m},
    new MenuItem { Id = 3, Name = "Chocolate Cake", Category = "Dessert", Price= 30.5m }
};

[HttpGet]
public IActionResult GetAll()
    {
        return Ok(menuItems);
    }

[HttpGet("{id}")]
public IActionResult GetById(int id)
    {
        var menuItem = menuItems.Find(item => item.Id == id);

        if (menuItem == null)
        {
            return NotFound();
        }

        return Ok(menuItem);
    }
}