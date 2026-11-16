using AddisEats.Api.Models;

namespace AddisEats.Api.Services.MenuItemServices;

public interface IMenuInterfaceService
{
    List<MenuItem> GetAll();

    MenuItem? GetById(int id);
}