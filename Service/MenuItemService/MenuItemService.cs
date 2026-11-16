using AddisEats.Api.Models;

namespace AddisEats.Api.Services.MenuItemServices;

public class MenuItemService : IMenuInterfaceService
{
    private readonly List<MenuItem> _menuItems;

    public MenuItemService()
    {
        _menuItems = new List<MenuItem>
        {
            new MenuItem { Id = 1, Name = "Cheeseburger", Category = "Main Course", Price= 10.5m},
            new MenuItem { Id = 2, Name = "Caesar Salad", Category = "Appetizer", Price= 20.5m},
            new MenuItem { Id = 3, Name = "Chocolate Cake", Category = "Dessert", Price= 30.5m }

        };
    }

    public List<MenuItem> GetAll()
    {
        return _menuItems;
    }

    public MenuItem? GetById(int id)
    {
        return _menuItems.FirstOrDefault(item => item.Id == id);
    }
}